using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButtonController : MonoBehaviour
{
    public ChairController chairController; // ChairController에 대한 레퍼런스

    void OnTriggerEnter(Collider other)
    {
        // 다른 Collider와 충돌이 발생했을 때 동작을 수행합니다.
        if (IsController(other.gameObject))
        {
            // Oculus 컨트롤러의 특정 버튼이 눌렸는지 확인
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                // 여기서 추가적인 동작 수행
                Debug.Log("컨트롤러 버튼이 눌렸습니다.");

                // 추가적인 동작을 여기에 추가
                // 예를 들어, StartMoveUp 함수 호출 등
                chairController.StartMoveUp();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // 다른 Collider와 충돌이 끝났을 때 동작을 수행합니다.
        if (IsController(other.gameObject))
        {
            // 트리거 버튼이 눌리지 않았을 때의 동작 수행
            chairController.StopMove();
        }
    }

    bool IsController(GameObject obj)
    {
        // 입력을 받을 컨트롤러 여부 확인
        return obj.CompareTag("CustomHandLeft") || obj.CompareTag("CustomHandRight");
    }
}