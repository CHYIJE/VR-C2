using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // ȸ�� �ӵ�

    void Update()
    {
        // ���� ���� ��ǥ�踦 �������� �־��� �ӵ��� ȸ��
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime, Space.Self);
    }
}