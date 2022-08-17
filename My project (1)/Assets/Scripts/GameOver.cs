using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
   public TextMeshProUGUI gameOverScore;
   public void tryAgain()
    {
        SceneManager.LoadScene(1);

    }


    void Start()
    {   
        gameOverScore.text = "Skor \n" + RingActive.score.ToString();
        RingActive.score = 0;
      
    }

    public void exit()
    {
        Application.Quit();
    }
}
