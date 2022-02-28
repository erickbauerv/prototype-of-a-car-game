using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 24.0f;
    private float spawnPosX = 30.0f; 
    private float spawnPosY = 0.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start(){
        // Spawn the animal prefabs with no need of pressing S
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    // Spawn a random animal prefab at a random location
    void SpawnRandomAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), spawnPosY, spawnPosZ);
        Vector3 spawnPosLeft = new Vector3(-spawnPosX, spawnPosY, Random.Range(-6,21));
        Vector3 spawnPosRight = new Vector3(spawnPosX, spawnPosY, Random.Range(-6,21));
        
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], spawnPosLeft, Quaternion.Euler(0,90,0));
        Instantiate(animalPrefabs[animalIndex], spawnPosRight, Quaternion.Euler(0,-90,0));
    }
}
