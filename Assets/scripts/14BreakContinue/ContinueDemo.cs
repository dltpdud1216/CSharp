using UnityEngine;

public class ContinueDemo : MonoBehaviour
{
    public int n = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)//n번 반복
        {
            if (i % 3 == 0 )
            {
                continue;
            }
            //sum = sum+i;
            sum += i;
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
   
}

/*
[Q]
1부터 100까지의 정수의 합을 구하는데 3의 배수를 제외하고 합을 구하세요

*/
