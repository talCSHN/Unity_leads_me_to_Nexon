using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    //void Start()
    //{
        
    //}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 spawnPos = Camera.main.transform.position + ray.direction.normalized * 23.0f;

            GameObject bamsongi = Instantiate(bamsongiPrefab, spawnPos, Quaternion.identity);
            bamsongi.GetComponent<BamsongiController>().Shoot(ray.direction.normalized * 2000f);

        }    
    }
}
