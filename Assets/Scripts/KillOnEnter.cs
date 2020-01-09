using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnEnter : MonoBehaviour
{
    //player and/or monster is destroyed if they enter collider 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obj")
        {
            Destroy(other.gameObject);
        }
    }
}
