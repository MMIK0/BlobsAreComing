using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    //scene managment, applied to buttons to reload or change scene
    public void ChangeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
