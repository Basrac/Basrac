using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScenesMove : MonoBehaviour
{
    public void GameScenesCtrl()
    {
        SceneManager.LoadScene("KWKScene");
        Debug.Log("Main Menu Scene");
    }
}
