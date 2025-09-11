using UnityEngine;

//기본 매개변수 (Default Parameter) : 매개변수 선언 시 초기화 한다
public class FunctionDefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //메세지 출력 함수 호출
        PrintMessage();

        string errorLog = Printlog();
        Debug.Log(errorLog);

        //디폴트 파라미터
        PrintError("에러 메세지", 4);
        PrintError("에러 메세지");

    }

   
    void PrintMessage()
    {
        string msg = "디버그";
        Debug.Log(msg);
    }

    void PrintError(string message, int level=1)
    {
        Debug.Log($"error message: 레벨 {level}");
    }
    string Printlog()
    {
        string log = "로그";
        return log;
    }
}


