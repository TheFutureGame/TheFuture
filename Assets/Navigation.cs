using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public Button openGlobeButton;
    public Button openSampleSceneButton;

    // Start is called before the first frame update
    void Start()
    {
        openGlobeButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Globe", LoadSceneMode.Single);
        });
        openSampleSceneButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
