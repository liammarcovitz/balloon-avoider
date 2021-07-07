using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            backToMenu();
        }
    }

    public void backButton()
    {
        backToMenu();
    }

    private void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
