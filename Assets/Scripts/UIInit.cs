using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInit : MonoBehaviour
{
    private static GameObject uiInstance;

    private void Awake()
    {
        if (uiInstance != null && uiInstance != gameObject)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(uiInstance = gameObject);
        }
    }
}
