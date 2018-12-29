using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class UIManager : Singleton<UIManager>
{
    public GameObject uiInstance;
}

public class UIInit : MonoBehaviour
{
    void Start()
    {
        
    }
    private void Awake()
    {
        var uiManager = UIManager.Instance;
        if (uiManager.uiInstance != null && uiManager.uiInstance != gameObject)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(uiManager.uiInstance = gameObject);
        }
    }
}
