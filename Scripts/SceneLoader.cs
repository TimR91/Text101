using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; //declared and defined CurrentSceneIndex want to know what the current build index 
        SceneManager.LoadScene(currentSceneIndex + 1);//loads next scene
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
