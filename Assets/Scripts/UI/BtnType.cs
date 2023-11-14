using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType CurrentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }
    bool isSound;
    public void OnBtnClick()
    {
        switch (CurrentType)
        {
            case BTNType.New:
                SceneLoader.LoadSceneHandle("Play", 0);
                //Debug.Log("새로하기");
                break;
            case BTNType.Continue:
                SceneLoader.LoadSceneHandle("Play", 0);
                //Debug.Log("이어하기");
                break;
            case BTNType.Option:
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                //Debug.Log("옵션");
                break;
            case BTNType.Sound://버튼 눌렀을때 효과음 
                if (isSound)
                {
                  //  Debug.Log("사운드OFF");
                }
                else
                {   
                  //  Debug.Log("사운드ON");
                }
                break;
            case BTNType.Back:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(optionGroup);
               // Debug.Log("�뒤로가기");
                break;
            case BTNType.Quit:
                Application.Quit();
              //  Debug.Log("게임종료");
                break;
        }
    }
    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.2f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
