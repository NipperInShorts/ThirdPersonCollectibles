using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public GameObject bonusObject;
    private int numPickedUp;
    private int numToPickUp;
    // Start is called before the first frame update
    void Start()
    {
        numToPickUp = GameObject.FindGameObjectsWithTag("Pick Up").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup() {
        numPickedUp += 1;
        if (numPickedUp == numToPickUp)
        {
            SpawnBonus();
        }
    }

    void SpawnBonus() {
        GameObject.Instantiate(bonusObject, transform);
    }
}
