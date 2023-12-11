using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation3 : MonoBehaviour
{
    // ȸ�� �ӵ� ������ ���� ����
    public float rotationSpeed = 50f;

    void Update()
    {
        // ���������� Y ���� �߽����� ȸ��
        RotateObject(Vector3.up);
    }

    void RotateObject(Vector3 axis)
    {
        // Time.deltaTime�� ����Ͽ� ȸ�� �ӵ��� �ʴ� �� ���� ���� ����
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // ���� ������Ʈ�� transform�� ����Ͽ� Y ���� �߽����� ȸ��
        transform.Rotate(axis, rotationAmount, Space.World);
    }
}