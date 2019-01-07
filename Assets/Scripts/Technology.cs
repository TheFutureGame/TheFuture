using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TechnologyType
{
    BrainComputerInterface,
    Turrets,
}

[System.Serializable]
public class Technology
{
    public float researchCost;
    public TechnologyType type;
    public bool isResearching = false;
    public bool isResearched = false;
}
