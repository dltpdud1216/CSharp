using UnityEngine;
using System;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //str String 변수 선언하고 초기화
        string str = ""; //빈 값으로 초기화
        str = String.Empty;  //빈 값으로 초기화 + using System;
        str = " Abc Def Fed Cba "; //앞 뒤에 공백 하나씩 주어서 값을 저장
         
        Debug.Log(str);
        Debug.Log(str.Length); //문자열 길이 구하기 : 17
        Debug.Log(str[5]); //D
        Debug.Log(str.ToUpper()); //대문자 출력
        Debug.Log(str.ToLower()); //소문자 출력

        //공백 제거
        Debug.Log(str.Trim()); //앞쪽 부분에 있는 공백, 뒤쪽 부분에 있는 공백 제거
        Debug.Log(str.TrimStart()); //앞쪽 부분에 있는 공백만 제거
        Debug.Log(str.TrimEnd()); //뒤쪽 부분에 있는 공백만 제거

        //검색
        Debug.Log(str.IndexOf('e'));    //'e'가 위치한 인덱스(방 위치)가져오기 : 6
        Debug.Log(str.Substring(5, 3)); //5번 인덱스(방 위치)부터 3글자 가져오기 : Def
        Debug.Log(str.Substring(5));    //5번 인덱스부터 끝까지 모두 가져오기 : Def Fed Cba 
        Debug.Log(str.Remove(5,3));     //5번 인덱스(방 위치)부터 3글자 삭제하기

        //비교
        Debug.Log(str[1] == str[15]); //1번 인덱스와 15번 인덱스가 동일한 문자인지 : false
        Debug.Log("ABC".Equals("Abc")); // ABC와 Abc가 동일한지 : false(대소문자 구분)
        Debug.Log(String.Compare("BAC", "Bac")); // Compare (같으면 0 반환, 앞에 있는 문자열이 크게 틀릴 경우 1, 뒤에 있는 문자열이 크게 틀릴 경우 -1) : 1

        //연결하기
        var hi1 = "안녕";
        var hi2 = "하세요";

        Debug.Log(hi1 + hi2);       //더하기 연산
        Debug.Log($"{hi1}{hi2}");   //보간법
        Debug.Log(String.Format("{0}{1}",hi1,hi2)); // Format() = 0번 위치에 hi1, 1번 위치에 hi2
        Debug.Log(String.Format("{0:C}",1000));     // C 통화 단위 표시
        Debug.Log(String.Format("{0:#,###}", 100000)); //세자리 단위로 , 표시

        //분리하기, 전체 공백제거
        //" Abc Def Fed Cba "
        string[] strArray = str.Trim().Split(' '); //띄어쓰기 기준으로 분리되어 각 인덱스에 Abc,Def,Fed,Cba 들어감
        string strAll = "";

        foreach (var item in strArray)
        {
            strAll = strAll + item; 
        }
        Debug.Log(strAll); //AbcDefFedCba


    }

  
}
