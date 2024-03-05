using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradedFood : Food
{
    
    public override void checkIfActive()
    {
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
