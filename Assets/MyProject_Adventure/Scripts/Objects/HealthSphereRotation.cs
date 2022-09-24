using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSphereRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
