using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{

    public static bool _GameIsPaused = false;
    public GameObject _PauseMenuUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(_GameIsPaused == true)
            {
                ResumeTheGame();
            }
            else
            {
                PauseTheGame();
            }
        }
    }

    public void ResumeTheGame()
    {
        _PauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        _GameIsPaused = false;
    }

    public void PauseTheGame()
    {
        _PauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        _GameIsPaused = true;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
