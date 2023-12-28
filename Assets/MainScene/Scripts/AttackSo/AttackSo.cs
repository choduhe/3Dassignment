using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName ="DefaultAttackData",menuName ="WeaponData",order = 0)]
public class AttackSo : ScriptableObject
{
    [Header("Attack Info")]
    public float damage;
    public float size;
}
