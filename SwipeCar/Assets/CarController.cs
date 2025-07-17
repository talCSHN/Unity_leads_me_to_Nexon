using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        Application.targetFrameRate = 60;    
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //this.speed = 0.2f;  // 처음 속도 설정
            this.startPos = Mouse.current.position.ReadValue();
        }
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            // 마우스 버튼에서 손가락 뗐을 때 좌표
            Vector2 endPos = Mouse.current.position.ReadValue();
            float swipeLength = endPos.x - this.startPos.x;

            // 스와이프 길이 -> 처음 속도로 변환
            this.speed = swipeLength / 500.0f;

            // 효과음 재생
            GetComponent<AudioSource>().Play();
        }


        // Translate : 게임 오브젝트를 현재 좌표에서 인수 값만큼 이동시키는 메서드
        // 인수 값들 -> 현재 좌표값이 아님. 현재 좌표의 상대적인 이동 값임
        transform.Translate(this.speed, 0, 0);  // 이동
        this.speed *= 0.98f;    // 감속
    }
}
