using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnOffButtonController : MonoBehaviour
{
    public MixObjectController mixController; // MixObjectController�� ���� ���۷���

    void OnMouseDown()
    {
        // On/Off ��ư Ŭ�� �� ������ �����մϴ�.
        mixController.OnMixObjectToggle();
    }
}