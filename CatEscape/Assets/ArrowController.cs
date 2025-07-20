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
        // 수직낙하
        transform.Translate(0, -0.1f, 0);

        // 화면 밖 -> 오브젝트 소멸
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 충돌 판정
        Vector2 p1 = transform.position;    // 화살 중심 좌표
        Vector2 p2 = this.player.transform.position;    // 플레이어 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;    // 화살 반지름
        float r2 = 1.0f;    // 플레이어 반지름

        // 충돌한 경우
        if (d < r1 + r2)
        {
            // DecreasHp() 호출
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            // 부딪힌 화살 지움
            Destroy(gameObject);
        }
    }
}
