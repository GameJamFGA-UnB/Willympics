using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class leve1call : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void creditos()
    {
        SceneManager.LoadSceneAsync(5);
    }
}
