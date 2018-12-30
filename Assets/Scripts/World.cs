using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// represents simulated World
public class World : MonoBehaviour
{
    public float simulationSpeed;
    public float defaultSimulationSpeed = 1;
    public float breedingPeriodSeconds;

    public static World currentWorld
    {
        get
        {
            return GameObject.FindGameObjectWithTag("GameController").GetComponent<World>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
