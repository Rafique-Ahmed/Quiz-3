using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemyPrefab;

    // private Vector3 spawnPos = 
     private float startDelay = 2;
     private float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle(){
        float spawnPosX = Random.Range(-6, 6);
       
        int enemyindex = Random.Range(0, 3);
        Instantiate(EnemyPrefab[enemyindex], new Vector3(spawnPosX,0,0), EnemyPrefab[enemyindex].transform.rotation);
        
    }
}
