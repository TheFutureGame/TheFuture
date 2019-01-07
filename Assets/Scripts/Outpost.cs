using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outpost : MonoBehaviour
{
    public float defaultMoney;
    public float defaultComputationalPower;

    public float Money
    {
        get => money;
        set
        {
            world.Money += (value - money);
            money = value;
        }
    }
    public float ComputationalPower
    {
        get => computationalPower;
        set
        {
            world.ComputationalPower += (value - computationalPower);
            computationalPower = value;
        }
    }

    private float money;
    private float computationalPower;
    private World world;

    private void Start()
    {
        world = World.CurrentWorld;
        Money = defaultMoney;
        ComputationalPower = defaultComputationalPower;
    }

    private void OnDestroy()
    {
        Money = 0;
        ComputationalPower = 0;
    }

    private void Update()
    {
        Money += Time.deltaTime;
        ComputationalPower += Time.deltaTime * 0.5f;
    }
}
