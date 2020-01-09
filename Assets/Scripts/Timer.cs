using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float timerStart;
    public Text textBox;

    
    //Timer start
    void Start()
    {
        textBox.text = timerStart.ToString("F2");
    }

   
    //Timer is updated 
    void Update()
    {
        if (PlayerMovementScript.instance != null)
        {
            timerStart += Time.deltaTime;
            textBox.text = timerStart.ToString("F2");
        }

    }
}
