using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_ObstacleSpawner : MonoBehaviour
{
    //public GameObject obstacleSpawner;
    public GameObject[] obstacleSpawner;
    public GameObject[] obstacles;
    public Vector3 spawnPosition;
    public Transform playerPosition;
    private Vector3 playerVec;
    public float targetTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(obstacles[0]);
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement(); 
        SpawnObstacle();   
    }

    private void Movement()
    {
        playerVec.z = playerPosition.position.z;
        transform.position = playerVec + spawnPosition;
    }

    private void SpawnObstacle()
    {
        int randSpawn = Random.Range(0, 10);
        int randObstacle = Random.Range(0, 2);
        
        Vector3 randSpawnPosition = obstacleSpawner[randSpawn].transform.position;
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            Instantiate(obstacles[randObstacle], randSpawnPosition, Quaternion.identity);
            targetTime = 1.0f;
        }
    }
}