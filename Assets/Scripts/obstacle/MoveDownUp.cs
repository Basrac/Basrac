using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownUp : MonoBehaviour
{
    public float moveSpeed = 4.0f; // Ÿ���� �̵� �ӵ�
    public float moveDistance = 4.0f; // Ÿ���� ���Ʒ� �̵� �Ÿ� 

    private Vector3 initialPosition;
    private bool movingDown = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // �Ʒ����� ���� �̵�
        if (movingDown)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        // �̵� �Ÿ��� ����� ������ �ٲ�
        if (Vector3.Distance(initialPosition, transform.position) >= moveDistance)
        {
            movingDown = !movingDown;
        }
    }
}
