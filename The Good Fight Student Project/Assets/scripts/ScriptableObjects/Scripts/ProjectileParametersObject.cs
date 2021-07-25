using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Int", menuName = "ScriptableObjects/Objects/Projectile")]
public class ProjectileParametersObject : ScriptableObject
{
    public float Mass;
    public float Speed;

    public int Damage;
    public float LiveSpan;

    //public GameObject ImpackParticals;
}
