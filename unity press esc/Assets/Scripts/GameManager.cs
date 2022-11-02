using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool OptionBtnOn;
    public GameObject OptionUI;
    
    public void ChangeSceneBtn(string buttonName)
    {
        switch (buttonName)
        {
            case "NewGameBtn":
                SceneManager.LoadScene("StageScene");
                break;
                       
            case "BackToStageBtn":
                SceneManager.LoadScene("StageScene");
                break;
            

        }
        switch (buttonName)
        {
            case "OptionBtn":
                Debug.Log("옵션버튼 눌렀습니다.");
                OptionUI.SetActive(true);
                break;


            case "OptionXBtn":
                OptionUI.SetActive(false);
                break;
        }
        
    }
   
    public void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
