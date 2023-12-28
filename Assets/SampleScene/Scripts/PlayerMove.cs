using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
    public float jumpPower;
    public int itemCount;
    public GameManager manager;
    bool isJump;
    Rigidbody rigid;
    AudioSource audiosource;

    private void Awake()
    {
        audiosource = GetComponent<AudioSource>();
        rigid = GetComponent<Rigidbody>();
        isJump = false; //맨처음에는 점프가 안되는 상태
    }
    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump")&&!isJump)  //isJump가 true
        {
            isJump = true;
            rigid.AddForce(new Vector3(0,jumpPower,0),ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(x, 0, z),ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            isJump = false;                                             //다시 점프상태를 초기화
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            itemCount++;
            audiosource.Play();
            other.gameObject.SetActive(false);                        //disenable 작동
            manager.GetItem(itemCount);

        }
        else if(other.tag =="Finish")
        {
           if( manager.TotalItemCount == itemCount)
            {
                SceneManager.LoadScene("MainScene");
            }
           else
            {
                SceneManager.LoadScene("SampleScene");
            }

        }
    }
}
