using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] enemies;
    public float spawnRate = 5f;
    float nextSpawn = 0.0f;
    

    // Update is called once per frame
    //Set timer and conditions when and how often enemies should spawn
    void Update()
    {
        if(Time.time > nextSpawn && PlayerMovementScript.instance != null)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnRandom();
        }
    }

    //checks array and spawns one of the added enemy
    void SpawnRandom()
    {
        Instantiate(enemies[Random.Range(0, enemies.Length)]);
    }
}
