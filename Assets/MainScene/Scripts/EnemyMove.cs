
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 1f;
 
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(-20f, -10f);
        float z = Random.Range(-40f, -20f);

        transform.position += new Vector3(x, 0, z) * speed * Time.deltaTime;
    }
}
