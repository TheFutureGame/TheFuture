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
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(uiInstance = gameObject);
        }
    }
}
