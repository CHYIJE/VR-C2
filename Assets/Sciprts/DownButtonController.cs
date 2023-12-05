using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DownButtonController : MonoBehaviour
{
    public ChairController chairController; // ChairController�� ���� ���۷���

    void OnTriggerEnter(Collider other)
    {
        // �ٸ� Collider�� �浹�� �߻����� �� ������ �����մϴ�.
        if (other.CompareTag("CustomHandLeft") || other.CompareTag("CustomHandRight"))
        {
            chairController.StartMoveDown(); // ������ �Ʒ��� �������� �����ϴ� �Լ� ȣ��
        }
    }

    void OnTriggerExit(Collider other)
    {
        // �ٸ� Collider�� �浹�� ������ �� ������ �����մϴ�.
        if (other.CompareTag("CustomHandLeft") || other.CompareTag("CustomHandRight"))
        {
            chairController.StopMove(); // ������ �������� ���ߴ� �Լ� ȣ��
        }
    }
}