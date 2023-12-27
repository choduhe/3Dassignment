using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void Start()
    {
        
    }
  
    void Update()
    {
        transform.Rotate(Vector2.up* 20 *Time.deltaTime,Space.World); //¿ùµå·Î ¹Ù²ãÁÜ
    }

   
}
