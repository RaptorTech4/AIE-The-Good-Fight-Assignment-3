using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScroller : MonoBehaviour
{

    public float _ScrollSpeed;
    public float _WorldLenth;
    
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - _ScrollSpeed);
        if(transform.position.z <= _WorldLenth)
        {
            Time.timeScale = 0.0f;
        }
    }
}
