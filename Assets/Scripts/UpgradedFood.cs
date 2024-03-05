using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradedFood : Food
{
    public override void checkIfActive()
    {
        if (gameObject.transform.position.z > 20)
        {
            gameObject.SetActive(false);
        }
    }
   /* private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            gameObject.SetActive(false);
        }
    }
    private void Update()
    {
        checkIfActive();
    } */ 
}
