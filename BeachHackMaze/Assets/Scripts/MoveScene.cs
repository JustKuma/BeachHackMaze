using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public int sceneChoose;
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneChoose);
    }
    public void playButton()
    {
        SceneManager.LoadScene(sceneChoose);
    }
}
