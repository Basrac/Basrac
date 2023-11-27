using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryBtnButtonClick : MonoBehaviour
{  
    public void RetryButtonClick(string currentSceneName)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
