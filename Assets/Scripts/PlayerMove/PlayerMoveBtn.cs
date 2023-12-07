using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBtn : MonoBehaviour
{
    public bool IsLeftButtonDown;
    public bool IsRightButtonDown;
    public bool IsJumpButtonClick;

    // Start is called before the first frame update
    void Start()
    {
        IsLeftButtonDown = false;
        IsRightButtonDown = false;
        IsJumpButtonClick = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LeftPointerDown()
    {
        IsLeftButtonDown = true;
    }

    public void LeftPointerUp()
    {
        IsLeftButtonDown = false;
    }

    public void RightPointerDown()
    {
        IsRightButtonDown = true;
    }

    public void RightPointerUp()
    {
        IsRightButtonDown = false;
    }

    public void JumpBtnClick()
    {
        IsJumpButtonClick = true;
    }
}