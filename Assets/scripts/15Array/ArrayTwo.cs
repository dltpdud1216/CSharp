using UnityEngine;

public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*  //[1-1] 1차원 배열 선언, 요소수(갯수) 생성, 값 초기화 
          int[] intArray = new int[3] { 1, 2, 3 };*/
        //[1-3] 1차원 배열 선언, 요소수 생성 생략, 값 초기화
        //int[] intArray = new int[] { 1, 2, 3, 4 }; //[] 값을 안넣어도 {} 안에 값을 넣으면 자동으로 {}에 맞는 방이 생성됨
        //[1-3] 1차원 배열 선언과 값 초기화
        int[] intArray = { 1, 2, 3, 4, 5 };

        //[2] 배열 사용
        foreach (int num in intArray)
        {
            //반복 실행문
            Debug.Log(num);

        }
    }
}

