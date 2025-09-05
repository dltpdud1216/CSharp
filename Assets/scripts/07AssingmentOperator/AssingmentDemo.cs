using UnityEditor.Rendering;
using UnityEngine;

//할당(대입) 연산자 (=) : 변수에 값을 저장
public class AssingmentDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {/*
        string name = "홍길동";
        int age = 19;
        Debug.Log($"이름은 {name}, 나이는 {age}");    */

        int i = 100;
        int j = 200;
        int temp = 0; // 0 없이도 가능

        Debug.Log($"처음값 i : {i}, j: {j}, temp: {temp}");


        temp = i; //temp에 i 할당
        i = j;    //i에 j 할당
        j = temp; //j에 temp 할당

        Debug.Log("결과는 : "+"i:"+i + "j:"+j + "temp :"+ temp );
        Debug.Log($"나중값 i : {i}, j: {j}");

        //i 200, j 100, temp 100 
    }


}
/* 
 * [Q] 
 * +,*,- 등 다른 연산 없이 변수 i와 j의 값을 서로 바꾸어서 저장하세요
 * hint) temp 변수를 만들어서 이용하세요
 * 
 * [output] 
 * 처음값 i: 100, j : 200
 * 나중값 i: 200, j : 100
 */