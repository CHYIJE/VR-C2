using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButtonController : MonoBehaviour
{
    public ChairController chairController; // ChairController�� ���� ���۷���

    void OnTriggerEnter(Collider other)
    {
        // �ٸ� Collider�� �浹�� �߻����� �� ������ �����մϴ�.
        if (IsController(other.gameObject))
        {
            // Oculus ��Ʈ�ѷ��� Ư�� ��ư�� ���ȴ��� Ȯ��
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                // ���⼭ �߰����� ���� ����
                Debug.Log("��Ʈ�ѷ� ��ư�� ���Ƚ��ϴ�.");

                // �߰����� ������ ���⿡ �߰�
                // ���� ���, StartMoveUp �Լ� ȣ�� ��
                chairController.StartMoveUp();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // �ٸ� Collider�� �浹�� ������ �� ������ �����մϴ�.
        if (IsController(other.gameObject))
        {
            // Ʈ���� ��ư�� ������ �ʾ��� ���� ���� ����
            chairController.StopMove();
        }
    }

    bool IsController(GameObject obj)
    {
        // �Է��� ���� ��Ʈ�ѷ� ���� Ȯ��
        return obj.CompareTag("CustomHandLeft") || obj.CompareTag("CustomHandRight");
    }
}