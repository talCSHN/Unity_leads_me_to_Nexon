using UnityEngine;
using System.Collections.Generic;
using System;

public class Test1 : MonoBehaviour
{
    private void Start()
    {
        //int ballondor = Convert.ToInt32(Console.ReadLine());
        const int ballondor = 5;
        if (ballondor == 5)
        {
            Debug.Log("SIUUUUUU");
        }
        else if (ballondor == 8)
        {
            Debug.Log("Messi == JOAT");
        }
        for (int i = 0; i < ballondor; i++)
        {
            Debug.Log("Ronaldo == GOAT");
        }
    }

    private void Update()
    {
        
    }
}
