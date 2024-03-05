using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] _animalPrefabs;
    public float xRange = 20;
    public float zPos = 20;
    private int animalIndex;
    private Vector3 _randomLocation;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }
    

    void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0,_animalPrefabs.Length);

        _randomLocation = new Vector3(Random.Range(-xRange, xRange), 0, zPos);
        Instantiate(_animalPrefabs[animalIndex], _randomLocation,
            _animalPrefabs[animalIndex].transform.rotation);
    }
}
