using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DownButtonController : MonoBehaviour
{
    public ChairController chairController; // ChairController에 대한 레퍼런스

    void OnTriggerEnter(Collider other)
    {
        // 다른 Collider와 충돌이 발생했을 때 동작을 수행합니다.
        if (other.CompareTag("CustomHandLeft") || other.CompareTag("CustomHandRight"))
        {
            chairController.StartMoveDown(); // 의자의 아래로 움직임을 시작하는 함수 호출
        }
    }

    void OnTriggerExit(Collider other)
    {
        // 다른 Collider와 충돌이 끝났을 때 동작을 수행합니다.
        if (other.CompareTag("CustomHandLeft") || other.CompareTag("CustomHandRight"))
        {
            chairController.StopMove(); // 의자의 움직임을 멈추는 함수 호출
        }
    }
}