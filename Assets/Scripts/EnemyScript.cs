using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemyMoveSpeed;
    public int enemyDamage;

    //set distance and speed in which the enemies move towards the player
    void FixedUpdate()
    {
      if(PlayerMovementScript.instance != null)
        {
            if (Vector2.Distance(transform.position, PlayerMovementScript.instance.transform.position) < 50f)
            {
                transform.position = Vector2.MoveTowards(transform.position, PlayerMovementScript.instance.transform.position, enemyMoveSpeed * Time.fixedDeltaTime);
            }
        }
    }

    //checks the enemys hit onto player and the damage value
    private void OnTriggerEnter2D(Collider2D hit)
    {
        PlayerMovementScript player = hit.GetComponent<PlayerMovementScript>();

        if(player != null)
        {
            player.DamageTaken(enemyDamage);
        }
    }


}
