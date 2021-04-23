using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    public Rigidbody _RB;
    public float _Speed;

    void Start()
    {
        _RB = GetComponent<Rigidbody>();
        _RB.velocity = transform.forward * _Speed;
    }
}
