using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairController : MonoBehaviour
{
    private bool isMoving = false; // ������ ������ ����
    public float moveSpeed = 1f; // ������ ������ �ӵ�
    public float moveDistance = 1f; // ������ ������ �Ÿ�

    void Update()
    {
        if (isMoving)
        {
            // �������� Ȱ��ȭ�� ���¿��� ó���� ������ ���⿡ �߰�
            Move();
        }
    }

    void Move()
    {
        // ���ڸ� �� �Ʒ��� �����̴� ������ �߰��մϴ�.
        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float newPosition = Mathf.Clamp(transform.position.y + translation, transform.position.y - moveDistance, transform.position.y + moveDistance);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
    }

    public void StartMoveUp()
    {
        isMoving = true; // ������ ���¸� Ȱ��ȭ
    }

    public void StartMoveDown()
    {
        isMoving = true; // ������ ���¸� Ȱ��ȭ
    }

    public void StopMove()
    {
        isMoving = false; // ������ ���¸� ��Ȱ��ȭ
    }

    // �Ʒ��� �߰��� �޼���
    public void StopMoveUp()
    {
        if (Input.GetButtonUp("Vertical"))
        {
            StopMove();
        }
    }

    public void StopMoveDown()
    {
        if (Input.GetButtonUp("Vertical"))
        {
            StopMove();
        }
    }
}