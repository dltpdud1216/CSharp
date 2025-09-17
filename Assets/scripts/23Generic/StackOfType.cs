using UnityEngine;
using System.Collections.Generic;

public class StackOfType : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Stack <T> 클래스 인스턴스 생성 - 문자열 전용
        //Stack<string> : <string> 전용 stack 클래스 인스턴스 생성
        Stack<string> stack = new Stack<string>();

        //[2]데이터 넣기,저장
        stack.Push("TEN");
        stack.Push("10");

        //[3]데이터 사용
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());


    }


}
/*
제네릭 클래스: 형식 매개변수로 T로 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
Generic Class : Cup<T> 컵어브티, 전용컵


*/