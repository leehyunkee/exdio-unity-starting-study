using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����Ƽ�� ~~�� ����� ���ڴ� �Ҷ� �ۼ��Ѵ�.

public class player : MonoBehaviour
{
    private Enemy m_Enemy;



    [SerializeField]
    public int m_hp;     //�÷��̾��� ü��
    [SerializeField]
    public string m_name;   //�÷��̾��� �̸�

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�÷��̾� ����");


        m_hp = 100;
        m_name = "����Ӹ�";
        Debug.Log("�÷��̾��� ü����" + m_hp + "�� �ʱ�ȭ�մϴ�.");
        Debug.Log("�÷��̾��� �̸���" + m_name + "�� �ʱ�ȭ�Ǿ����ϴ�.");

    }

    // Update is called once per frame
    void Update()
    {

        m_Enemy.m_hp
        if (Input.GetKeyDown(KeyCode.A))
        {
            IncreaseHP();
            Debug.Log("�÷��̾��� ü����" + m_hp + "�� �Ǿ����ϴ�.");


        }
    }

    //�Լ� ����
    private void IncreaseHP()
    {
        m_hp = m_hp + 1; //���� Hp���� 1��ŭ �����Ѵ�.-> ü���� �����Ѵ�
    }

}
