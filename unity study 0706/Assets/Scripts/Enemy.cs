using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����Ƽ�� ~~�� ����� ���ڴ� �Ҷ� �ۼ��Ѵ�.

public class Enemy : MonoBehaviour
{
    [SerializeField]

    private int m_Attack;

    public int      m_hp;     //�÷��̾��� ü��

    public string   m_name;   //�÷��̾��� �̸�

    // Start is called before the first frame update
    void Start()
    {
       
        m_hp    = 10;
        m_name = "����Ӹ�";
        Debug.Log("�÷��̾��� ü����" + m_hp + "�� �ʱ�ȭ�Ǿ����ϴ�.");
        Debug.Log("�÷��̾��� �̸���" + m_name + "�� �ʱ�ȭ�Ǿ����ϴ�.");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            IncreaseHP();
            Debug.Log("�÷��̾��� ü����" + m_hp + "�� �Ǿ����ϴ�.");


        }
        if(Input.GetKeyUp(KeyCode.B))
        {
            MovePlayer();

        }
    }

    //�Լ� ����
    private void IncreaseHP()
    {
        m_hp = m_hp +1; //���� Hp���� 1��ŭ �����Ѵ�.-> ü���� �����Ѵ�
    }
    private void MovePlayer()
    {
        transform.position += new Vector3(1, 0, 0);
    }
}
