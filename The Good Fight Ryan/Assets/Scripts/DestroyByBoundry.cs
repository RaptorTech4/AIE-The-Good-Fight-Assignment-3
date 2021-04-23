using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundry : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {

        Destroy(other.gameObject);
        }
    }

}
