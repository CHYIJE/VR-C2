using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OculusVRInteraction : MonoBehaviour
{
    public OVRInput.Controller controller; // Oculus 컨트롤러를 지정
    public GameObject uiObject; // 클릭 시 활성화할 UI GameObject를 참조

    private bool isUIActive = false; // UI 활성화 상태를 추적

    private void Update()
    {
        // Oculus 컨트롤러의 주 트리거 버튼을 감지
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controller))
        {
            Ray ray = new Ray(transform.position, transform.forward); // 컨트롤러의 전방 방향으로 레이 생성
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject) // 클릭된 객체 확인
                {
                    ToggleUI();
                }
            }
        }
    }

    private void ToggleUI()
    {
        isUIActive = !isUIActive; // UI 상태 토글
        if (uiObject != null)
        {
            uiObject.SetActive(isUIActive); // UI 활성화 또는 비활성화
        }
    }
}
