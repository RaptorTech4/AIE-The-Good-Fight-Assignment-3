using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRocket : MonoBehaviour
{

    public GameObject _RocketExposion;
    public GameObject _PlayerExposion;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Boundary")
        {
            return;
        }

        Instantiate(_RocketExposion, transform.position, transform.rotation);

        if(other.tag == "Player")
        {
            return;
        }
        if(other.tag == "Terrain")
        {
            Destroy(gameObject);
            return;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
