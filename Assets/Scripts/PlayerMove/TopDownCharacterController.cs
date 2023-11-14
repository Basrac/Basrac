using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopDownCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnJumpEvent;
    public event Action OnLandEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void Update()
    {
    }

    // 점프 시 이벤트 추가 
    public void CallJumpEvent()
    {
        OnJumpEvent?.Invoke();
    }

    // 착지 시 이벤트 추가 
    public void CallLandEvent()
    {
        OnLandEvent?.Invoke();
    }
}

