using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 20.0f;
    private float xRange = 20;
    public GameObject[] projectilePrefab;


    // Update is called once per frame
    void Update()
    {
        CheckBounds();
        
        PlayerMovement();
        
        CreateProjectile();
    }
    // ABSTRACTION
    private void PlayerMovement()
    {
        // Player movement left to right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
    // ABSTRACTION
    private void CreateProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject pooledProjectile = ObjectPooler.SharedInstance.pooledObjects[1];
            if (pooledProjectile != null)
            {
                pooledProjectile.transform.position = transform.position;
                pooledProjectile.transform.rotation = transform.rotation;
                pooledProjectile.SetActive(true);
            }
        }
    }
    // ABSTRACTION
    private void CheckBounds()
    {
        // Check for left and right bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
