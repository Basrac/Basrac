using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightLeft : MonoBehaviour
{
    public float moveSpeed = 4.0f; // Ÿ���� �̵� �ӵ�
    public float moveDistance = 4.0f; // Ÿ���� ���Ʒ� �̵� �Ÿ� 

    private Vector3 initialPosition;
    private bool movingRight = true;
   

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        //  �����ʿ��� �������� �̵�
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // �̵� �Ÿ��� ����� ������ �ٲ�
        if (Vector3.Distance(initialPosition, transform.position) >= moveDistance)
        {
            movingRight = !movingRight;
        }
    }

    
}
