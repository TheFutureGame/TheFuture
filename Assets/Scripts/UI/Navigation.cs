﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public Button openGlobeButton;
    public Button researchButton;
    public Button craftButton;

    // Start is called before the first frame update
    void Start()
    {
        openGlobeButton.onClick.AddListener(() =>
        {
        });
        researchButton.onClick.AddListener(() =>
        {
        });
    }

    void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);

        /*Scene scene = SceneManager.GetSceneByName(sceneName);
        if (scene != null)
        {
            if (!scene.isLoaded)
            {
                SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
                scene = SceneManager.GetSceneByName(sceneName);
            }
            
            SceneManager.SetActiveScene(scene);
        }*/
    }
}
