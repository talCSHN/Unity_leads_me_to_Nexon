using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.car = GameObject.Find("car_0");
        this.flag = GameObject.Find("flag_0");
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length >= 0)
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Game Over";
        }
    }
}
