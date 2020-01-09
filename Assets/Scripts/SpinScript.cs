using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //using this to make the lasertraps rotate
        if(PlayerMovementScript.instance != null)
        {
          transform.Rotate(new Vector3(0f, 0f, -100f) * Time.deltaTime);
        }
       
    }
}
