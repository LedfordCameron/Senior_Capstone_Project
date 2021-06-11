using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void NextScene(){
        SceneManager.LoadScene("Blake_ws");    
    }

    public void QuitGame(){
        Application.Quit();
    }
}
