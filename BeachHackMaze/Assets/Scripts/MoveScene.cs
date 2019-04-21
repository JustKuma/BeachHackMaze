using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public int num;
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(num);
    }
}
