using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "NewGameBtn":
                SceneManager.LoadScene("StageScene");
                break;
            case "OptionBtn":
                SceneManager.LoadScene("OptionScene");
                break;
            case "BackToStageBtn":
                SceneManager.LoadScene("StageScene");
                break;
            case "OptionXBtn":
                SceneManager.LoadScene("StageScene");
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
