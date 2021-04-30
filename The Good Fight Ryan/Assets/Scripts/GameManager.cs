using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject _EnemyRockets;
    public Vector3 _RocketSpawnValues;
    public int _RocketCount;
    public float _RocketStart;
    public float _RocketSpawnDelay;
    public float _RocketWaveDelay;

    public Image _HealthBar;
    public float _PlayerHalf;
    public GameObject _PlayerShip;
    public GameObject _PlayerExplosion;

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

    public void DamageRecived(float damage)
    {
        _PlayerHalf = _PlayerHalf - damage;
        _HealthBar.fillAmount = _PlayerHalf;
        if(_PlayerHalf <= 0)
        {
            Instantiate(_PlayerExplosion,_PlayerShip.transform.position,_PlayerShip.transform.rotation);
            Destroy(_PlayerShip);
        }
    }

}
