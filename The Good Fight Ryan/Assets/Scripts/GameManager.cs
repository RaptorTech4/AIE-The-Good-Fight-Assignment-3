using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject _EnemyRockets;
    public Vector3 _RocketSpawnValues;
    public int _RocketCount;
    public float _RocketStart;
    public float _RocketSpawnDelay;
    public float _RocketWaveDelay;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }


    void Update()
    {

    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(_RocketStart);

        while (true)
        {
            for (int i = 0; i < _RocketCount; i++)
            {
                Vector3 spawnPostion = new Vector3(Random.Range(-_RocketSpawnValues.x, _RocketSpawnValues.x), _RocketSpawnValues.y, _RocketSpawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(_EnemyRockets, spawnPostion, spawnRotation);
                yield return new WaitForSeconds(_RocketSpawnDelay);
            }
            yield return new WaitForSeconds(_RocketWaveDelay);
        }

    }
}
