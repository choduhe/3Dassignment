using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 Offset;

    private void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }
   

    // Update is called once per frame
    void LateUpdate()  //카메라 이동은 lateupdate
    {
        transform.position = playerTransform.position + Offset;
    }
}
