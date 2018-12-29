using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontalRotation = -Input.GetAxis("Horizontal") * rotationSpeed;
        float verticalRotation = Input.GetAxis("Vertical") * rotationSpeed;

        transform.Rotate(verticalRotation, horizontalRotation, 0);
    }
}
