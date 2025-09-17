using UnityEngine;

public class TryCatchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 5; //설정된 인덱스보다 초과되어 오류가 생김
        }
        catch //try{}에서 오류 발생시 catch 실행
        {
            Debug.Log("에러가 발생했습니다");

        }

    }
 
}

/*
 예외 처리(Exception Handling) : 오류(Error)

- 문법 오류
- 런타임 오류 
- 알고리즘 오류

예외처리
try
{
    //명령문....
}

catch
{
    //명령문 실행중 예외(exception) 발생할때만 처리할 내용
    //....
}


*/