using UnityEngine;

public class ForCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 countdown 하는 프로그램 구현
        for (int i =1; i <= 5; i++)
        { 
            Debug.Log($"증가 contdown:{i}");
        }

        Debug.Log("============================"); //구분선

        //5부터 1까지 countdown 하는 프로그램 구현
        for (int i = 5; i >= 1; i--)
        {
            Debug.Log($"감소 contdown:{i}");
        }

        //무한루프 :버그 
       //실행 xx/ for (; ; )
        {
            Debug.Log("무한루프");
        }
    }

   
}
