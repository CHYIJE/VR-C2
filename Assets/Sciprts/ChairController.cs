using UnityEngine;

public class ChairController : MonoBehaviour
{
    private float moveSpeed = 5f; // �̵� �ӵ�
    private float maxYPosition = 0.9f; // ������ �� �ִ� �ִ� Y ��ǥ ��
    private float minYPosition = 0.45f; // ������ �� �ִ� �ּ� Y ��ǥ ��
    private float targetYPosition; // ��ǥ Y ��ǥ ��
    private float smoothTime = 0.05f; // �ε巯�� �̵��� ���� �ð� ��

    void Awake()
    {
        // ó���� ���ڸ� �ּ� Y ��ǥ�� ����
        transform.position = new Vector3(transform.position.x, minYPosition, transform.position.z);
        targetYPosition = minYPosition;
    }

    void Update()
    {
        // Oculus ��Ʈ�ѷ��� A ��ư�� ������ ��
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            MoveUp();
        }

        // Oculus ��Ʈ�ѷ��� B ��ư�� ������ ��
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            MoveDown();
        }

        // ������ ������
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, targetYPosition, transform.position.z), smoothTime);
    }

    void MoveUp()
    {
        // ��ǥ ��ġ�� �ִ� Y ��ǥ�� ����
        targetYPosition = maxYPosition;
    }

    void MoveDown()
    {
        // ��ǥ ��ġ�� �ּ� Y ��ǥ�� ����
        targetYPosition = minYPosition;
    }

    void MoveToNewPosition(float targetYPosition)
    {
        // Ư�� ��ġ�� �̵�
        targetYPosition = 1.36F;
    }
}