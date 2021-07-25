using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Int", menuName = "ScriptableObjects/Objects/Turret")]
public class TurretObject : ScriptableObject
{
    public GameObject Bullet;
    public float TurretRange;
    public float TurretTurnSpeed;
    public float TurretFireRate;

    public HealthObject TurretHealth;
}
