using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float movepower = 4f; //�÷��̾ �����̴� �� ����
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
        //time deltatime �� �������� �Ϸ�Ǳ���� �ɸ� �ð��� ���մϴ�.
        //�������� �ٸ� ��ǻ�ͷ� ���������� ��� ����?����?�ϰ� �����̰� �����ش�.
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