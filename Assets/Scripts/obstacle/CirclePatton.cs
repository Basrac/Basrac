using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclePatton : MonoBehaviour
{
    public float rotationSpeed = 30.0f; // ȸ�� �ӵ� (����/��)
    public float radius = 5.0f; // ���� ������

    private Vector3 initialPosition;
    private float angle = 0;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        angle += rotationSpeed * Time.deltaTime;
        angle = angle % 360;

        float x = Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
        float y = Mathf.Sin(angle * Mathf.Deg2Rad) * radius;

        Vector3 newPosition = initialPosition + new Vector3(x, y, 0);
        transform.position = newPosition;
    }
}
