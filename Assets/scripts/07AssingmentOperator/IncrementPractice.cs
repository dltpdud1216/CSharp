using UnityEngine;

public class IncrementPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number1 = 3;
        int number2 = 5;

        int result1 = 0;
        int result2 = 0;

        number1--; //3
        result1 = ++number1; //4

        ++number2; //6
        result2 = number2--; //4

        Debug.Log($"result1: {result1}");   //=3
        Debug.Log($"result2: {result2}");   //=6
    }

    // Update is called once per frame
    
}
