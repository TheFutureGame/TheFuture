using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region : MonoBehaviour
{
    public int numberOfMen;
    public int numberOfWomen;
    public Vector2Int populationGrowth;

    // shows that this region has some men and women in it
    public bool isAlive
    {
        get
        {
            return _isAlive;
        }
    }

    private World world;
    private bool _isAlive = true;

    void Start()
    {
        world = World.currentWorld;
        StartCoroutine(Breeding());
    }

    IEnumerator Breeding()
    {
        while (true)
        {
            yield return new WaitForSeconds(world.breedingPeriodSeconds);
            _isAlive = numberOfMen > 0 && numberOfWomen > 0;

            if (!_isAlive)
            {
                continue;
            }

            numberOfMen += (int)(Random.Range(populationGrowth.x, populationGrowth.y) * world.simulationSpeed);
            numberOfWomen += (int)(Random.Range(populationGrowth.x, populationGrowth.y) * world.simulationSpeed);

            if (numberOfMen < 0)
            {
                numberOfMen = 0;
            }
            if (numberOfWomen < 0)
            {
                numberOfWomen = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
