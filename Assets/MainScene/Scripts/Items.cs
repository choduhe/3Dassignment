using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
   public enum Type {Ammo,Coin,Grenade,Heart,Weapon }
    public Type type;
    public int Value;

    private void Update()
    {
        transform.Rotate(Vector3.up * 20 *Time.deltaTime);
    }
}
