using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickContinue()
    {
        Debug.Log("����ϱ�");
    }

    public void OnClickNewGame()
    {
        Debug.Log("�� ����");
    }

    public void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void OnClickOption()
    {
        Debug.Log("ȯ�漳��");
    }
}
