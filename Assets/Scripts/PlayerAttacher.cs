using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacher : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player");
        if (other.CompareTag("Player"))
        {
            other.transform.parent = transform;
        }
        if (gameObject.CompareTag("Revealer")) {
            //gameObject.GetComponent
        }
    }
       
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
            other.transform.parent = null;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
    }

}
