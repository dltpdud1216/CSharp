using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    public int x = 5;
    public int y = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = 0; //0으로 나누면 예외발생

        try //예외가 발생할 가능성이 있는 구문이 들어오는 코드블록
        {
            result = x / y; 
            //[1]
            Debug.Log($"[1]:{x}/{y}={result}");
        }
        catch //try절에서 예외가 발생하면 catch절을 실행
        {
            //[2]
            Debug.Log("[2]:예외가 발생 했습니다");
        }
        finally //try절에서 예외 발생 여부와 상관 없이 무조건 실행
        {
            //[3]
            Debug.Log("[3]:Finally절을 실행합니다");
        }

        //정상일 경우 : [1] > [3]
        //오류가 생길 경우 : [2] > [3]
    }

   
}
