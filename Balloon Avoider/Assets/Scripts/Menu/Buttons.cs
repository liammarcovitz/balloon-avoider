using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void playGame()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1;
        PauseMenu.isPaused = false;

    }

    public void loadShop()
    {
        SceneManager.LoadScene("Shop");
    }
    
    public void exitGame()
    {
        Application.Quit();
    }
}
