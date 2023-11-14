using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownUp : MonoBehaviour
{
    public float moveSpeed = 4.0f; // 타겟의 이동 속도
    public float moveDistance = 4.0f; // 타겟의 위아래 이동 거리 

    private Vector3 initialPosition;
    private bool movingDown = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // 아래부터 위로 이동
        if (movingDown)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        // 이동 거리를 벗어나면 방향을 바꿈
        if (Vector3.Distance(initialPosition, transform.position) >= moveDistance)
        {
            movingDown = !movingDown;
        }
    }
}
