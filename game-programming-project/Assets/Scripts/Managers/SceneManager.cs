using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManager : MonoBehaviour
{
    
    public static SceneManager main;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        main = this;
    }

    public void Load(int bIndex)
    {
        //Load the scene with a build index
        UnityEngine.SceneManagement.SceneManager.LoadScene(bIndex);
    }

    public void AddScene(int bIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(bIndex, LoadSceneMode.Additive);
    }

    public void RemoveScene(int bIndex)
    {
        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(bIndex);
    }
}
