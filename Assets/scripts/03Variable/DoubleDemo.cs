using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 선언 및 초기화
        float f = 3.14f;
        double d = 3.14; // 대소문자 구분 없음(생략하면 자동으로 Double형으로 인식)
        //float에서 f를 생략하면 d로 자동인식해서 용량이 달라 오류가 남
        decimal m = 3.14m;

        float min = float.MinValue;
        float max = float.MaxValue;

        //[2] 변수 사용
        Debug.Log(f);
        Debug.Log(d);
        Debug.Log(m);

        Debug.Log(min); //-3.402823E+38 > 단위가 너무 커 38자리라는 요약 
        Debug.Log(max);

        
    }

    
}
/*
 실수형 데이터 형식(훨씬 많이 저장 할 수 있지만 정확하지 않음)/ 정수 0 = 0, 실수 0 = 근사값
ex) 0.1~0.2 사이에 있는지?

Float   : 32 Bit, 부동 소수점 숫자
Double  : 64 Bit, 부동 소수점 숫자
Decimal : 128 Bit, 부동 소수점 숫자 - 단위가 크고 정확해서 금융권에서 주로 사용함 

 */