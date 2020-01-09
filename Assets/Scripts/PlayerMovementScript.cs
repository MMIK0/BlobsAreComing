using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementScript : MonoBehaviour
{
    public static PlayerMovementScript instance;
    public float speed;
    Vector2 movement;
    public Rigidbody2D playerRB;
    private bool hasDashed;
    public int health = 100;
    public Slider hpBar;
    //setting static instance, monsters will chase the object holding this script
    private void Awake()
    {
        instance = this;
    }

    // setting the axis in which player moves
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //sets slider to respond on changes to health
        hpBar.value = health;

        //dash for the player to use in difficult situations
        if (Input.GetKeyDown(KeyCode.Space) && hasDashed == false)
        {
            hasDashed = true;
            StartCoroutine("DashMove");
        }
    }
    //setting the player movement and speed
     void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + movement * speed * Time.fixedDeltaTime);
    }

    //setting coroutine for dashing
    IEnumerator DashMove()
    {
        speed += 10f;
        yield return new WaitForSeconds(0.2f);
        speed -= 10f;
        yield return new WaitForSeconds(2f);
        hasDashed = false;
    }

    //checks health if the enemy did hit you
    public void DamageTaken(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
