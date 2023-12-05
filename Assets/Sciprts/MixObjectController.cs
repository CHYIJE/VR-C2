using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixObjectController : MonoBehaviour
{
    public GameObject chair; // ���� ������Ʈ�� ���� ���۷���
    public GameObject lowerBox; // �Ʒ��� ������Ʈ�� ���� ���۷���

    private bool isMixObjectOn = true; // MIX ������Ʈ�� ON/OFF ����

    void Start()
    {
        // �ʱ�ȭ �ڵ� �ۼ�
    }

    void Update()
    {
        // �� �����Ӹ��� ����Ǵ� �ڵ� �ۼ�
    }

    public void OnChairButtonUp()
    {
        // ���ڸ� UP�ϴ� ���� �ڵ� �ۼ�
        chair.transform.Translate(Vector3.up * Time.deltaTime);
    }

    public void OnChairButtonDown()
    {
        // ���ڸ� DOWN�ϴ� ���� �ڵ� �ۼ�
        chair.transform.Translate(Vector3.down * Time.deltaTime);
    }
    public void OnChairClick()
    {
        // ���ڸ� Ŭ���ϴ� ���� �ڵ� �ۼ�
        // ���� ���, ���ڸ� ȸ����Ű�ų� �ٸ� ������ ����
        Debug.Log("���ڰ� Ŭ���Ǿ����ϴ�.");
    }



    public void OnLowerBoxButtonClick()

    {
        // �Ʒ����� Ŭ���ϴ� ���� �ڵ� �ۼ�
        // ���� ���, �Ʒ����� ���ų� �ٸ� ������ ����
    }

    public void OnMixObjectToggle()
    {
        // MIX ������Ʈ�� ON/OFF ����ϴ� ���� �ڵ� �ۼ�
        isMixObjectOn = !isMixObjectOn;
        gameObject.SetActive(isMixObjectOn);
    }
}