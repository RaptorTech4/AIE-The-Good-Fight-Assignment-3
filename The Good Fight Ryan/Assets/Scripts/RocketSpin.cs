using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSpin : MonoBehaviour
{

    public float _RocketSpin;

    void Update()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, Time.deltaTime * _RocketSpin));
    }
}
