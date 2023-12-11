using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairController : MonoBehaviour
{
    private bool isMoving = false; // 의자의 움직임 상태
    public float moveSpeed = 1f; // 의자의 움직임 속도
    public float moveDistance = 1f; // 의자의 움직임 거리

    void Update()
    {
        if (isMoving)
        {
            // 움직임이 활성화된 상태에서 처리할 로직을 여기에 추가
            Move();
        }
    }

    void Move()
    {
        // 의자를 위 아래로 움직이는 로직을 추가합니다.
        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float newPosition = Mathf.Clamp(transform.position.y + translation, transform.position.y - moveDistance, transform.position.y + moveDistance);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
    }

    public void StartMoveUp()
    {
        isMoving = true; // 움직임 상태를 활성화
    }

    public void StartMoveDown()
    {
        isMoving = true; // 움직임 상태를 활성화
    }

    public void StopMove()
    {
        isMoving = false; // 움직임 상태를 비활성화
    }

    // 아래에 추가된 메서드
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