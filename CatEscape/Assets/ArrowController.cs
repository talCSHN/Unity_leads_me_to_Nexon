using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.player = GameObject.Find("player_0");
    }

    // Update is called once per frame
    void Update()
    {
        // ��������
        transform.Translate(0, -0.1f, 0);

        // ȭ�� �� -> ������Ʈ �Ҹ�
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // �浹 ����
        Vector2 p1 = transform.position;    // ȭ�� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;    // �÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;    // ȭ�� ������
        float r2 = 1.0f;    // �÷��̾� ������

        // �浹�� ���
        if (d < r1 + r2)
        {
            // DecreasHp() ȣ��
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            // �ε��� ȭ�� ����
            Destroy(gameObject);
        }
    }
}
