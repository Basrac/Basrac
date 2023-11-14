using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float moveSpeed = 4.0f; // Ÿ���� �̵� �ӵ�
    public float moveDistance = 4.0f; // Ÿ���� ���Ʒ� �̵� �Ÿ� 

    private Vector3 initialPosition;
    private bool movingLeft = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // ���ʿ��� ���������� �̵�
        if (movingLeft)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        // �̵� �Ÿ��� ����� ������ �ٲ�
        if (Vector3.Distance(initialPosition, transform.position) >= moveDistance)
        {
            movingLeft = !movingLeft;
        }
    }
}
