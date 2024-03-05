using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Food : MonoBehaviour
{
    private float zBound = 30f;
    public float ZBound
    {
        get
        {
            return zBound;
        }
        set
        {
            zBound = value;
        }
    }
    private void Start()
    {
        zBound = 30f;
    }

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
    // ABSTRACTION
    public virtual void checkIfActive()
    {
        if (gameObject.transform.position.z > zBound)
        {
            gameObject.SetActive(false);
        }
    }
}
