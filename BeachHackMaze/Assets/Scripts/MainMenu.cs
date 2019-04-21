using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Maze Scene");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void Credit()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
