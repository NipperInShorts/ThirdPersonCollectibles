using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Controls")]
    [Tooltip("The Axis around which the game object is rotating")]
    [SerializeField] Vector3 rotationAxis = new Vector3(1.0f, 1.0f, 1.0f);

    [Tooltip("The speed with which the gameObject is rotating. Measured in deg/second")]
    [SerializeField] float rotationSpeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
