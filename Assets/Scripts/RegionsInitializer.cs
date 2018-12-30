using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RegionsConfig
{
    public CountryData[] countries;
}

public class RegionsInitializer : MonoBehaviour
{
    public TextAsset defaultData;
    public RegionsConfig regionsConfig;
    public GameObject countriesHolder;
    public GameObject regionPrefab;

    void Start()
    {
        regionsConfig =  JsonUtility.FromJson<RegionsConfig>(defaultData.text);

        foreach (var countryData in regionsConfig.countries)
        {
            var countryGameObject = new GameObject();
            countryGameObject.name = countryData.countryName;

            foreach (var regionData in countryData.regions)
            {
                var regionGameObject = Instantiate(regionPrefab);
                regionGameObject.name = regionData.regionName;
                // regionGameObject.transform.rotation = Quaternion.Euler(0, -regionData.latitude, regionData.longitude);
                regionGameObject.transform.rotation = Quaternion.Euler(0, -regionData.longitude , regionData.latitude);

                var regionComponent = regionGameObject.AddComponent<Region>();
                regionComponent.data = regionData;
                regionGameObject.transform.parent = countryGameObject.transform;
            }

            countryGameObject.transform.parent = countriesHolder.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
