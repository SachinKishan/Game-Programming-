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
        main = this;
    }

    public void Load(int bIndex)
    {
        //Load the scene with a build index
        UnityEngine.SceneManagement.SceneManager.LoadScene(bIndex);
    }
}
