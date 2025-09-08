using Unity.VisualScripting;
using UnityEngine;


public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] AndOperator
        Debug.Log(true && true);    // 둘 다 참일 경우  : 참
        Debug.Log(true && false);   // 둘 중에 하나라도 거짓인 경우 : 거짓
        Debug.Log(false && true);
        Debug.Log(false && false);  // 둘 다 거짓인 경우 : 거짓

        // [2] OrOperator (Or 연산자)
        Debug.Log(true || true);    // 둘 중에 하나라도 참일 경우  : 참
        Debug.Log(true || false);   
        Debug.Log(false || true);
        Debug.Log(false || false);  // 둘 다 거짓인 경우 : 거짓

        //[3] NotOperator : !
        Debug.Log(!true);       // 참을 부정
        Debug.Log(!false);      // 거짓을 부정
    }

    
}
/*논리 연산자(Logical Operator)
 *  결과 : true, false

[1] AndOperator (And 연산자) : &&
ㄴ (앞,뒤) 둘 다 참일때만 참

[2] OrOperator (Or 연산자) : ||
ㄴ (앞,뒤) 둘 중에 하나라도 참이면 참

[3] NotOperator (부정 연산자) : !
ㄴ 참이면 거짓, 거짓이면 참

*/