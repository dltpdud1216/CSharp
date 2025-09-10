using UnityEngine;

// string : 문자(배)열
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 변수 선언 및 초기화
        string arr = "C#8";

        /*Debug.Log(arr);     //c#8
        Debug.Log(arr[0]);  //c
        Debug.Log(arr[1]);  //#
        Debug.Log(arr[2]);  //8*/

        foreach (var c in arr)
        {
            //반복 실행문
            Debug.Log(c);

        }

    }


}
