using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject _EnemyRockets;
    public Vector3 _RocketSpawnValues;
    
    void Start()
    {
        SpawnWaves();
    }

    
    void Update()
    {
        
    }

    void SpawnWaves()
    {
        Vector3 spawnPostion = new Vector3(Random.Range(-_RocketSpawnValues.x,_RocketSpawnValues.x),_RocketSpawnValues.y,_RocketSpawnValues.z);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(_EnemyRockets, spawnPostion, spawnRotation);
    }
}
