using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryBtnButtonClick : MonoBehaviour
{
    /*
    public void RetryButtonClick(string currentSceneName)
    {
        Debug.Log("��Ʈ���� ��ư Ŭ��: " + currentSceneName);
        SceneManager.LoadScene(currentSceneName); // ���� ���� �ٽ� �ε�
    }
    */
    public void RetryButtonClick(string currentSceneName)
    {
        Debug.Log("다음스테이지버튼: " + currentSceneName);

        string[] nextScenes = { "Stage1-1", "Stage1-2", "Stage1-3", "KWK_2-1 Stage", "EHL_Test(2-2 Stage)", "SG_Test(2-3 Stage)" };
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
