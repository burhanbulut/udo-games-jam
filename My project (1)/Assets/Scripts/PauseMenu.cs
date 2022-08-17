using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
     

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused=false;

    public GameObject pauseMenu;
    public GameObject panel ;
    [SerializeField]
    private TextMeshProUGUI score;
    [SerializeField]
    private TextMeshProUGUI currentScore;
    public void gameResume()
    {
        pauseMenu.SetActive(true);
        panel.SetActive(false);
        Time.timeScale= 1f;
        isGamePaused = false;
        score.gameObject.SetActive(true);

    }

    public void exitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void gamePause()
    {
        pauseMenu.SetActive(false);
        panel.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        score.gameObject.SetActive(false);
        currentScore.text = "Score: " + score.text;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                gameResume();

            }
            else
            {
                gamePause();
            }
        }
    }
}
