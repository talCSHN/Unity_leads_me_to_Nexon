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
            //this.speed = 0.2f;  // ó�� �ӵ� ����
            this.startPos = Mouse.current.position.ReadValue();
        }
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            // ���콺 ��ư���� �հ��� ���� �� ��ǥ
            Vector2 endPos = Mouse.current.position.ReadValue();
            float swipeLength = endPos.x - this.startPos.x;

            // �������� ���� -> ó�� �ӵ��� ��ȯ
            this.speed = swipeLength / 500.0f;

            // ȿ���� ���
            GetComponent<AudioSource>().Play();
        }


        // Translate : ���� ������Ʈ�� ���� ��ǥ���� �μ� ����ŭ �̵���Ű�� �޼���
        // �μ� ���� -> ���� ��ǥ���� �ƴ�. ���� ��ǥ�� ������� �̵� ����
        transform.Translate(this.speed, 0, 0);  // �̵�
        this.speed *= 0.98f;    // ����
    }
}
