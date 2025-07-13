using UnityEngine;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
    private void Start()
    {
        //int age;
        //age = 30;
        //Debug.Log(age);
        //float height = 160.5f;
        //float height2;
        //height2 = height;
        //Debug.Log(height2);
        string name;
        name = "Ronaldo";
        //Debug.Log(name);
        int answer = 10;
        answer += 10;
        answer++;
        Debug.Log(answer);
        string str1 = "GOAT";
        string factos = $"{name} {str1}";
        Debug.Log(factos);
        name += str1;
        Debug.Log(name);
    }

    private void Update()
    {
        
    }
}
