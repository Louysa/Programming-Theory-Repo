using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITANCE
public class UpgradedFood : Food
{
    // POLYMORPHISM
    public override void checkIfActive()
    {
        // ENCAPSULATION
        Food food = new Food();
        food.ZBound = 20f;
        if (gameObject.transform.position.z > food.ZBound)
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
