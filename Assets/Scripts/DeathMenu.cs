using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public GameObject eaten;
    public GameObject fried;

    //depending of the way of the death, set active right UI- panel
    public void Update()
    {
        if (PlayerMovementScript.instance.health <= 0)
        {
            eaten.SetActive(true);
        }
        else if (PlayerMovementScript.instance == null)
        {
            fried.SetActive(true);
        }
    }
}
