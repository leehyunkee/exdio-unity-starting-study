using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float movepower = 4f; //플레이어가 움직이는 힘 정도
    public float jumpPower = 4f;

    Rigidbody2D rigid;

    bool onPlatform = false;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

 
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
        }
        transform.position += moveVelocity * movepower * Time.deltaTime;
        //time deltatime 전 프레임이 완료되기까지 걸린 시간을 말합니다.
        //프레임이 다른 컴퓨터로 실행했을때 모두 공평?동일?하게 움직이게 ㅎ해준다.
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onPlatform == false)

        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);

            onPlatform = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            onPlatform = false;
        }
    }

}