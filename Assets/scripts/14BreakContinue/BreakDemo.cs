using UnityEngine;

public class BreakDemo : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        int i = 1;

        //[2] 조건식
        while (i <= 10)
        {


            if (sum >= 22)//조건식,필터링
            { break; }


            sum = sum + i;
            i++;
        }
        Debug.Log($"1부터 10까지의 정수의 합: {sum}");
    }

}

/*
[Q]
1부터 10까지의 정수의 합(sum)을 구하는 프로그램 구현
합이 22 이상이 되면 더이상 합을 구하지 않는다.

*/