using UnityEngine;

public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //크기가 3인 정수형 배열을 선언하고 초기화 
        int[] numbers = { 1, 2, 3 };

        Debug.Log ($"배열의 길이:{numbers.Length}"); //3,0~ numbers.Length-1

        //배열의 인덱스를 관리하는 변수로 0 으로 초기화
        int index = 0;

        Debug.Log(numbers[index++]); //numbers[0] - 1
        Debug.Log(numbers[index++]); //numbers[1] - 2
        Debug.Log(numbers[index++]); //numbers[2] - 3

        Debug.Log(numbers[--index]); //numbers[2] - 3
        Debug.Log(numbers[--index]); //numbers[1] - 2
        Debug.Log(numbers[--index]); //numbers[0] - 1


    }

    
}
