using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    GameObject _Player;
    public GameObject _TurretHead;
    public GameObject _ShootPoint;
    public GameObject _Bullet;

    public float _TurnSpeed;
    public float _FireRate;
    private float _NextFire;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            _Player = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _Player = null;
        }
    }

    private void FixedUpdate()
    {
        if(_Player!= null)
        {
            LockOnTarget();
        }
    }

    void LockOnTarget()
    {
        Vector3 dir = _Player.transform.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(_TurretHead.transform.rotation, lookRotation, Time.deltaTime * _TurnSpeed).eulerAngles;
        _TurretHead.transform.rotation = Quaternion.Euler(rotation.x, rotation.y, 0f);

        Shoot();
    }

    void Shoot()
    {
        if(Time.time > _NextFire)
        {
            _NextFire = Time.time + _FireRate;
            Instantiate(_Bullet, _ShootPoint.transform.position, _ShootPoint.transform.rotation);
        }
    }
}
