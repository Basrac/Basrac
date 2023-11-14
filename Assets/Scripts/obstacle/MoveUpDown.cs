using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public float moveSpeed = 4.0f; // 타겟의 이동 속도
    public float moveDistance = 4.0f; // 타겟의 위아래 이동 거리 

    private Vector3 initialPosition;
    private bool movingUp = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // 위에서 아래로 이동
        if (movingUp)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

        // 이동 거리를 벗어나면 방향을 바꿈
        if (Vector3.Distance(initialPosition, transform.position) >= moveDistance)
        {
            movingUp = !movingUp;
        }
    }
}
