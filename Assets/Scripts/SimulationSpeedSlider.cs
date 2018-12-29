using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulationSpeedSlider : MonoBehaviour
{
    public string[] valueToTextMap;
    public Text simulationSpeedText;

    private Slider slider;

    private void Start()
    {
        var slider = GetComponent<Slider>();
        slider.value = World.Instance.defaultSimulationSpeed;
        SetSimulationSpeed(slider.value);
        slider.onValueChanged.AddListener(SetSimulationSpeed);
    }

    void SetSimulationSpeed(float value)
    {
        int intValue = (int)value;
        if (valueToTextMap.Length > 0 && intValue >= 0 && intValue < valueToTextMap.Length)
        {
            simulationSpeedText.text = valueToTextMap[intValue];
            World.Instance.simulationSpeed = value;
        }
    }
}
