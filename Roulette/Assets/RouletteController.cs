using UnityEngine;
using UnityEngine.InputSystem;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        // ��� ȯ�濡�� �Ȱ��� �ӵ��� �����̵��� ����
        Application.targetFrameRate = 60;
    }

    
    void Update()
    {
        bool isClicked =
            (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame) ||
            (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame);
        // Ŭ���ϸ� ȸ�� �ӵ� ����
        // GetMouseButtonDown -> 0 - ���콺 ���� Ŭ�� / 1 - ���콺 ������ Ŭ�� / 2 - ���콺 �� Ŭ��
        // å�� �ִ°� ���� �ڵ���. �׷��� ���ܶ�
        //if (Input.GetMouseButtonDown(0))  // �̰� ���� ���� �� ��
        if (isClicked)
        {
            this.rotSpeed = 50;
        }

        // ȸ�� �ӵ���ŭ �귿 ȸ��
        // �� ��° ���� -> ��� - �ð� �ݴ� ���� / ���� - �ð� ����
        transform.Rotate(0, 0, -this.rotSpeed);

        // �귿 ����
        this.rotSpeed *= 0.97f;
    }
}
