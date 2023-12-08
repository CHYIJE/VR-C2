using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButtonController : MonoBehaviour
{
    public ChairController chairController; // ChairController�� ���� ���۷���

    void OnTriggerEnter(Collider other)
    {
        // �ٸ� Collider�� �浹�� �߻����� �� ������ �����մϴ�.
        if (IsController(other.gameObject))
        {
            chairController.StartMoveDown(); // ������ �Ʒ��� �������� �����ϴ� �Լ� ȣ��
        }
    }

    void OnTriggerExit(Collider other)
    {
        // �ٸ� Collider�� �浹�� ������ �� ������ �����մϴ�.
        if (IsController(other.gameObject))
        {
            chairController.StopMove(); // ������ �������� ���ߴ� �Լ� ȣ��
        }
    }

    bool IsController(GameObject obj)
    {
        // �Է��� ���� ��Ʈ�ѷ� ���� Ȯ��
        return obj.CompareTag("CustomHandLeft") || obj.CompareTag("CustomHandRight");
    }

    void Update()
    {
        // Oculus Input�� ���� Ʈ���� ��ư ���� ���� Ȯ��
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            // ���⼭ �߰����� ���� ����
            Debug.Log("Ʈ���� ��ư�� ���Ƚ��ϴ�.");

            // �߰����� ������ ���⿡ �߰�
            // ���� ���, StartMoveDown �Լ� ȣ�� ��
            chairController.StartMoveDown();
        }
        else
        {
            // Ʈ���� ��ư�� ������ �ʾ��� ���� ���� ����
            chairController.StopMove();
        }
    }
}