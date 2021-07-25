using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    public TurretObject TurretData;

    GameObject _Player;
    public GameObject _TurretHead;
    public GameObject _ShootPoint;

    private float _NextFire;

    private void Start()
    {
        SphereCollider col = GetComponent<SphereCollider>();
        col.radius = TurretData.TurretRange;
    }

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
        Vector3 rotation = Quaternion.Lerp(_TurretHead.transform.rotation, lookRotation, Time.deltaTime * TurretData.TurretTurnSpeed).eulerAngles;
        _TurretHead.transform.rotation = Quaternion.Euler(rotation.x, rotation.y, 0f);

        Shoot();
    }

    void Shoot()
    {
        if(Time.time > _NextFire)
        {
            _NextFire = Time.time + TurretData.TurretFireRate;
            Instantiate(TurretData.Bullet, _ShootPoint.transform.position, _ShootPoint.transform.rotation);
        }
    }
}
