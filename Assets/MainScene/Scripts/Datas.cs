using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datas : MonoBehaviour
{
    
   public EnemyStats stats;
    [Range(1, 100)] public int maxHealth;
    [Range(1, 30)] public int speed;

    public AttackSo attackso;
}
[Serializable]
public enum EnemyStats
{
    Override,
    player,
    type
}
