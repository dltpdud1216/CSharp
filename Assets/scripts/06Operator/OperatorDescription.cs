using UnityEngine;

// Operator (연산자) : +,-,*,/ 등 연산을 진행하는 키워드
public class OperatorDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*  Debug.Log(3 + 5); //8
          Debug.Log(3 - 5); //-2
          Debug.Log(3 * 5); //15
          Debug.Log(3 / 5); //0*/
        //문자열 + 정수는 문자+문자로 조합됨 ("결과는 : " +~~ ), LogDemo 파일 참고 

        /*    int value = 0;

            value = 8;      //value 변수에 8을 저장  >8
            value = +value; //값을 가져오는 것
            Debug.Log(value);

            value = -8;     >-8
            value = +value;
            Debug.Log(value);

            value = 8;      >-8
            value = -value;
            Debug.Log(value);

            value = -8;     >8
            value = -value;
            Debug.Log(value);*/

        int i = 5;
        int j = 3;
        int k;

        k = i + j;  //8
        Debug.Log(k);

        k = i - j;  //2
        Debug.Log(k);

        k = i * j;  //15
        Debug.Log(k);

        k = i / j;  //1
        Debug.Log(k);

        k = i % j;  //2
        Debug.Log(k);




    }




}
/* 
 * 단항 연산자 : +.-
 * 이항 연산자 : +,-,*,/,%
 * 삼항 연산자 : 
 * 
 */