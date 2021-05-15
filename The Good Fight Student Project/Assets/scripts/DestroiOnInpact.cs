using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiOnInpact : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "trurret")
        {
            return;
        }
        Destroy(gameObject);
    }
}
