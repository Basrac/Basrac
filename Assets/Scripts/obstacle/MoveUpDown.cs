using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public float moveSpeed = 4.0f; // Ÿ���� �̵� �ӵ�
    public float moveDistance = 4.0f; // Ÿ���� ���Ʒ� �̵� �Ÿ� 

    private Vector3 initialPosition;
    private bool movingUp = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // ������ �Ʒ��� �̵�
        if (movingUp)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

        // �̵� �Ÿ��� ����� ������ �ٲ�
        if (Vector3.Distance(initialPosition, transform.position) >= moveDistance)
        {
            movingUp = !movingUp;
        }
    }
}
