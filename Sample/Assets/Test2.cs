using UnityEngine;

public class Test2 : MonoBehaviour
{
    private void Start()
    {
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);
        Vector2 startPos = new Vector2(8.0f, 5.0f);
        Vector2 endPos = new Vector2(18.0f, 15.0f);
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);
    }
    
}
