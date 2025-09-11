using UnityEngine;

//전역 변수, 필드,멤버변수
//지역 변수
public class FunctionScope : MonoBehaviour
{
    string message = "전역 변수"; //필드,멤버 변수
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        showMessage();
        PrintMessage();
        Debug.Log(message);

        
    }

    //메세지를 출력하는 함수
    void showMessage()
    {
        string maessage = "지역변수";
        Debug.Log(maessage);

    }
    void PrintMessage()
    {
        Debug.Log(message);
    }
  
}
