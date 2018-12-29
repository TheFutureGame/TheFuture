using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed;
    public Vector3 rotationVector;

    void Update()
    {
        transform.Rotate(rotationVector * rotationSpeed * Time.deltaTime * World.currentWorld.simulationSpeed);
    }
}
