using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour
{
    public GameObject SoundPopup;
    public GameObject SettingPopup;
    public GameObject StageSelectPopup;

    //startscene관련 버튼
    public void StartBtnButtonClick()
    {
        SceneManager.LoadScene("Stage1-1");
    }
    
    public void SoundBtnButtonClick()
    {
        SoundPopup.SetActive(true);
    }

    public void LevelBtnButtonClick()
    {
        StageSelectPopup.SetActive(true);
    }

    // Popup관련 버튼 
    public void SettingBtnButtonClick()
    {
        SettingPopup.SetActive(true);
    }

    public void exitButtonClick()
    {
        StageSelectPopup.SetActive(false);
    }

    public void ExitBtnButtonClick()
    {
        SettingPopup.SetActive(false);
    }

    public void ExitButtonClick()
    {
        SoundPopup.SetActive(false);
    }

    // 공통 버튼
    public void HomeBtnButtonClick()
    {
        SceneManager.LoadScene("MainScene");
    }


    public void GameExitBtnButtonClick()
    {
        Application.Quit();
    }

    public void NextStageBtnButtonClick(string currentSceneName)
    { 
        Debug.Log("다음스테이지버튼: " + currentSceneName);

        string[] nextScenes = { "Stage1-1", "Stage1-2", "Stage1-3", "Stage2-1", "Stage2-2", "Stage2-3" };
        int currentIndex = System.Array.IndexOf(nextScenes, currentSceneName);

        if (currentIndex != -1 && currentIndex < nextScenes.Length - 1)
        {
            string nextSceneName = nextScenes[currentIndex + 1];
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.LogError("씬 찾을 수 없음.");
        }
    }
}