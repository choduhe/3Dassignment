using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpPower;
    public float speed;
    Vector3 Move;

    bool walkDown;

    Rigidbody rigid;
    Animator anim;

    private void Awake()
    {
        anim=GetComponentInChildren<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        walkDown = Input.GetButton("Walk");
        

        Move = new Vector3(x, 0, z).normalized;

        transform.position += Move * speed * (walkDown ? 0.3f : 1f)* Time.deltaTime;        //left shift를 누르면 0.3초가 참이고 아니면 속도 1

        anim.SetBool("isRun", Move != Vector3.zero);
        anim.SetBool("isWalk", walkDown);

        transform.LookAt(transform.position+Move);        //내가 바라보는 방향으로 위치이동

    
    }
}
