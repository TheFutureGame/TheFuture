using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// represents simulated World
public class World : MonoBehaviour
{
    public float simulationSpeed;
    public float defaultSimulationSpeed = 1;
    public float breedingPeriodSeconds;
    public float ComputationalPower
    {
        get => computationalPower;
        set
        {
            computationalPower = value;
            computationalPowerValueWidget.text = computationalPower.ToString("F2");
        }
    }
    public float Money
    {
        get => money;
        set
        {
            money = value;
            moneyValueWidget.text = money.ToString("F2");
        }
    }
    // UI
    public Text moneyValueWidget;
    public Text computationalPowerValueWidget;
    //
    public GameObject outpostsHolder;

    public static World CurrentWorld
    {
        get
        {
            return GameObject.FindGameObjectWithTag("GameController").GetComponent<World>();
        }
    }


    private float computationalPower;
    private float money;

    private void Start()
    {
        computationalPowerValueWidget.text = computationalPower.ToString("F2");
        moneyValueWidget.text = money.ToString("F2");
    }

    private void Update()
    {
    }
}
