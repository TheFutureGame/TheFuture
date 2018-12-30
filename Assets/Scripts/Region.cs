using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Region : MonoBehaviour
{
    public RegionData data;

    // shows that this region has some men and women in it
    public bool isAlive
    {
        get
        {
            return _isAlive;
        }
    }

    private World world;
    private bool _isAlive;

    void Start()
    {
        _isAlive = data.numberOfMen > 0 && data.numberOfWomen > 0;
        world = World.currentWorld;
        StartCoroutine(Breeding());
    }

    IEnumerator Breeding()
    {
        while (true)
        {
            yield return new WaitForSeconds(world.breedingPeriodSeconds);
            _isAlive = data.numberOfMen > 0 && data.numberOfWomen > 0;

            if (!_isAlive)
            {
                continue;
            }

            data.numberOfMen += (int)(Random.Range(data.populationGrowth.x, data.populationGrowth.y) * world.simulationSpeed);
            data.numberOfWomen += (int)(Random.Range(data.populationGrowth.x, data.populationGrowth.y) * world.simulationSpeed);

            if (data.numberOfMen < 0)
            {
                data.numberOfMen = 0;
            }
            if (data.numberOfWomen < 0)
            {
                data.numberOfWomen = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
