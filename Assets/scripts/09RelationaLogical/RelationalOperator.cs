using UnityEngine;

//RelationalOperator (관게 연산자, 비교연산자)
// <(작음), <=(작거나 같음), > (큼), >=(크거나 같음), == (같음) , !=(다름)
//결과 : true(참), false(거짓) = bool

public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);  // 참
        Debug.Log(x > y);  // 거짓
        Debug.Log(x <= y); // 참
        Debug.Log(x >= y); // 거짓
        Debug.Log(x == y); // 거짓
        Debug.Log(x != y); // 참

        Debug.Log("AAA" == "aaa"); //거짓


    }

   
   
}
