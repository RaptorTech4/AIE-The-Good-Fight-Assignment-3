using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Int", menuName = "ScriptableObjects/HealthObject")]
public class HealthObject : ScriptableObject
{
    public int Value;
    public int MaxValue;
}
