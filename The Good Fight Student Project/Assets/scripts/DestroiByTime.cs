using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiByTime : MonoBehaviour
{
    public float _LiveTime;

    void Start()
    {
        Destroy(gameObject, _LiveTime);
    }
}
