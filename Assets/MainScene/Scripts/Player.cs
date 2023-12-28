using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public GameObject[] weapons;
    public bool[] hasWeapons;
    Vector3 Move;

    bool walkDown;
    bool ItemDown;
    bool SwapDown1;
    bool SwapDown2;
    bool SwapDown3;

    Rigidbody rigid;
    Animator anim;

    GameObject nearObject;

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
        ItemDown = Input.GetButtonDown("Interation");
        SwapDown1 = Input.GetButtonDown("Swap1");
        SwapDown2 = Input.GetButtonDown("Swap2");
        SwapDown3 = Input.GetButtonDown("Swap3");


        Move = new Vector3(x, 0, z).normalized;

        transform.position += Move * speed * (walkDown ? 0.3f : 1f)* Time.deltaTime;        //left shift를 누르면 0.3초가 참이고 아니면 속도 1

        anim.SetBool("isRun", Move != Vector3.zero);
        anim.SetBool("isWalk", walkDown);

        transform.LookAt(transform.position+Move);        //내가 바라보는 방향으로 위치이동
    }

    void Swap()
    {
        int weaponIndex = -1;
        if (SwapDown1) weaponIndex = 0;
        if (SwapDown2) weaponIndex = 1;
        if (SwapDown3) weaponIndex = 2;
        if ((SwapDown1||SwapDown2||SwapDown3))
        {
            weapons[weaponIndex].SetActive(true);
        }
    }

    void Interation()
    {
        if (ItemDown && nearObject != null)
        {
            if (nearObject.tag == "Weapon")
            {
                Items items =nearObject.GetComponent<Items>();
                int weaponIndex = items.Value;
                hasWeapons[weaponIndex] = true;

                Destroy(nearObject);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Weapon")
        {
            nearObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag =="Weapon")
        {
            nearObject = null;  
        }
    }
}
