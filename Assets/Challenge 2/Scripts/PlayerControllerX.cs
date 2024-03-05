using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool spawned = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!spawned)
            {
                Invoke("checkSpawned",1);
            }
            else
            {
               Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spawned = false; 
            }
            
        }

        
    }

    void checkSpawned()
    {
        spawned = true;
    }
}
