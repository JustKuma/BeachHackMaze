using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Maze Scene");
    }

    public void QuitTheGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
