using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed;
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalRotation = -Input.GetAxis("Horizontal") * rotationSpeed;
        float verticalRotation = Input.GetAxis("Vertical") * rotationSpeed;

        // transform.Rotate(verticalRotation, horizontalRotation, 0);
        rb.AddTorque(new Vector3(verticalRotation, horizontalRotation, 0));
    }
}
