
using Unity.VisualScripting;
using UnityEngine;

public class FuncitonMinMax : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        int Result = GetMax(3, 5);
        Debug.Log($"3과5 중 큰 수는 {Result}이다");

        int minValue = GetMin(-3, -5);
        Debug.Log($"-3과-5 중 작은 수는 {minValue}이다");

        //-21의 절대값을 구해서 출력
        int abs = GetAbs(-21);
        Debug.Log($"-21의 절대값은 {abs}이다");
            


    }

    //[1] 매개변수로 받는 두 개의 정수 중 큰 수를 반환하는 함수를 구현


    int GetMax(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
        
            return y;
        }
    }
    //[2].매개변수로 입력 받은 두 개의 정수 중 작은 수를 반환하는 함수 구현

    int GetMin(int x, int y)
    {
        //3항 연산자
        int minValue = (x < y) ? x : y;
        return minValue;
    }

    int GetAbs (int number)
    {
        return (number< 0) ? -number : number;

    }
}

    //매개변수로 입력받은 정수의 절대값을 반환하는 함수 구현
    // -5 => 5, -99 = > 99, 5 => 5, 143 = > 143
   


/*
 3항 연산자
- 조건식이 참이면 첫번째 값을 가져다 사용, 거짓이면 두번째 값을 가져다 사용
(조건식-T,F) ? 첫번째 값: 두 번째 값;
*/

/*
[Q]7202

1.매개변수로 입력 받은 두 개의 정수 중 큰 수를 반환하는 함수를 구현
2.매개변수로 입력 받은 두 개의 정수 중 작은 수를 반환하는 함수 구현
3.3,5를 입력 받아 큰 수 출력
4.-3,-5를 입력 받아 작은 수 출력

[output]
3과5 중 큰 수는 {반환 받은 값} 이다
-3과-5 중 작은 수는 {반환 받은 값}출력 이다
*/