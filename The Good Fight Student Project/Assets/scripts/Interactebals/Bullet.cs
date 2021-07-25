using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public ProjectileParametersObject _Projectile;
    public HealthObject _PlayerHealth;
    Rigidbody _RB;

    void Start()
    {
        _RB = GetComponent<Rigidbody>();
        _RB.mass = _Projectile.Mass;
        _RB.velocity = transform.forward * _Projectile.Speed;
        Destroy(gameObject, _Projectile.LiveSpan);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trurret")
        {
            return;
        }
        if(other.gameObject.tag == "Player")
        {
            _PlayerHealth.Value = _PlayerHealth.Value - _Projectile.Damage;
        }
        Destroy(gameObject);
    }
}
