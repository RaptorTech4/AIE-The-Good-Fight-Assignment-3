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
            Instantiate(_PlayerExposion, other.transform.position, other.transform.rotation);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
