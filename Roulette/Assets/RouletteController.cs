using UnityEngine;
using UnityEngine.InputSystem;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        // 모든 환경에서 똑같은 속도로 움직이도록 고정
        Application.targetFrameRate = 60;
    }

    
    void Update()
    {
        bool isClicked =
            (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame) ||
            (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame);
        // 클릭하면 회전 속도 설정
        // GetMouseButtonDown -> 0 - 마우스 왼쪽 클릭 / 1 - 마우스 오른쪽 클릭 / 2 - 마우스 휠 클릭
        // 책에 있는거 옛날 코드임. 그래서 예외뜸
        //if (Input.GetMouseButtonDown(0))  // 이거 쓰면 실행 안 됨
        if (isClicked)
        {
            this.rotSpeed = 50;
        }

        // 회전 속도만큼 룰렛 회전
        // 세 번째 인자 -> 양수 - 시계 반대 방향 / 음수 - 시계 방향
        transform.Rotate(0, 0, -this.rotSpeed);

        // 룰렛 감속
        this.rotSpeed *= 0.97f;
    }
}
