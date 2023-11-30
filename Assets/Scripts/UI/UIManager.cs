using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject[] ui_Booms;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // 폭탄 아이템을 체크하는 함수
    public void BoomCheck(int boomCount)
    {
        for(int i = 0; i < ui_Booms.Length; i++)
        {
            if (i * 1 <= boomCount)
                ui_Booms[i].SetActive(true);
            else
                ui_Booms[i].SetActive(false);
        }
        //if (boomCount == 0)
        //{
        //    ui_Booms[0].SetActive(false);
        //    ui_Booms[1].SetActive(false);
        //    ui_Booms[2].SetActive(false);
        //}
        //if (boomCount == 1)
        //{
        //    ui_Booms[0].SetActive(true);
        //    ui_Booms[1].SetActive(false);
        //    ui_Booms[2].SetActive(false);
        //}
        //if (boomCount == 2)
        //{
        //    ui_Booms[0].SetActive(true);
        //    ui_Booms[1].SetActive(true);
        //    ui_Booms[2].SetActive(false);
        //}
        //if (boomCount == 3)
        //{
        //    ui_Booms[0].SetActive(true);
        //    ui_Booms[1].SetActive(true);
        //    ui_Booms[2].SetActive(true);
        //}
    }

}
