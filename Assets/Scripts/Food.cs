using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void Update()
    {
        checkIfActive();
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
                other.GetComponent<AnimalHunger>().FeedAnimal(1);
                gameObject.SetActive(false);
            
        }
    }
    
    private void checkIfActive()
    {
        if (gameObject.transform.position.z > 30)
        {
            gameObject.SetActive(false);
        }
    }
}
