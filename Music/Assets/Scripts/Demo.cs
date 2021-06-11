using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;
    public Text txtScore;
    void Start()
    {
        score = 0;
    }

    public void AddScore(){
        score++;
        txtScore.text = score.ToString();
    }

    public void GoToMainMenuScene(){
        SceneManager.LoadScene("Main_Menu");    
    }
}
