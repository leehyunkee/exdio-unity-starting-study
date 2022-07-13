using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 유니티의 ~~한 기능을 쓰겠다 할때 작성한다.

public class Enemy : MonoBehaviour
{
    [SerializeField]

    private int m_Attack;

    public int      m_hp;     //플레이어의 체력

    public string   m_name;   //플레이어의 이름

    // Start is called before the first frame update
    void Start()
    {
       
        m_hp    = 10;
        m_name = "현기머링";
        Debug.Log("플레이어의 체력이" + m_hp + "로 초기화되었습니다.");
        Debug.Log("플레이어의 이름이" + m_name + "로 초기화되었습니다.");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            IncreaseHP();
            Debug.Log("플레이어의 체력이" + m_hp + "가 되었습니다.");


        }
        if(Input.GetKeyUp(KeyCode.B))
        {
            MovePlayer();

        }
    }

    //함수 생성
    private void IncreaseHP()
    {
        m_hp = m_hp +1; //기존 Hp보다 1만큼 증가한다.-> 체력이 증가한다
    }
    private void MovePlayer()
    {
        transform.position += new Vector3(1, 0, 0);
    }
}
