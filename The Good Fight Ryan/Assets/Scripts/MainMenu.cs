using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject _HowToMenuUI;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("TestingScene");
    }

    public void HowTo()
    {
        _HowToMenuUI.SetActive(true);
    }

    public void BackToMainMenuUI()
    {
        _HowToMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
