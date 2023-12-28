
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{


    Datas datas;

    private void Awake()
    {
        datas = GetComponent<Datas>();
    }
    private void Start()
    {
        float x = Random.Range(-20f, -10f);
        float z = Random.Range(-40f, -20f);

        transform.position = new Vector3(x, 0, z)*datas.speed*Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
