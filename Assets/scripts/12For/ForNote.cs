using UnityEngine;


public class ForNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 증가하면서 증가한 값을 출력한다 : 5번 반복
        //count:1, count:2, count:3, count:4, count:5
        //1
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"count:{i + 1}");
        }
        //2
        for (int i = 1; i < 6; i++)
        {
            Debug.Log($"count:{i}");
        }
        //3
        for (int i = 1; i <= 5; i++)
        {
            Debug.Log($"count:{i}");
        }

        //i가 2씩 증가 - 0,2,4 찍힘
        for (int i = 0; i <5; i= i+2)
        {
            Debug.Log($"count:{i}");
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"count:{i ++}");
        }
    }


  
}
