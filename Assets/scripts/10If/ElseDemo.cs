using UnityEngine;

public class ElseDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (1 != 1)
        {
            //실행문 1
#pragma warning disable CS0162 // 접근할 수 없는 코드가 있습니다.
            Debug.Log("조건식이 참이면 실행문 1을 실행합니다");
#pragma warning restore CS0162 // 접근할 수 없는 코드가 있습니다.

        }
        else
        {
            Debug.Log("조건식이 거짓이면 실행문 2를 실행합니다");
        }
    }

 
}
/*
else 문 : 아니면
if 조건식이 참일때면 else실행문2는 실행하지 않습니다
if 조건식이 거짓일때면 else 실행문 2를 실행합니다

if(조건식)
{
//실행문 1
}
elsd 
{
//실행문 2
}
//실행문 3

1. 조건식이 참일 경우 
실행문 1 -> 실행문 3 실행

2/. 

 */