using UnityEngine;
using System.Collections.Generic;

//제네릭 리스트: 배열,제네릭 리스트 비교
public class ListOfint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 배열
        //정수형 배열 선언하고 요소수 생성
        int[] arrNumbers = new int[2];
        //배열 변수 초기화
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;

        //배열 사용
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);  
        }

        //[2] 제네릭 리스트 사용
        //List<T> : int 전용의 제네릭 리스트 인스턴스 생성
        List<int>listNumbers = new List<int>();

        //리스트에 데이터 추가
        listNumbers.Add(30);
        listNumbers.Add(40);
        listNumbers.Add(50);

        //리스트 사용
        for (int i = 0; i < listNumbers.Count ; i++) //컬렉션은 Length가 아닌 count / 배열은 인덱스를 미리 설정해놓기 때문에 Length, 컬렉션은 길이가 계속 변동되어 count
        {
            Debug.Log(listNumbers[i]);
        }

        listNumbers.Add(60);

        for (int i = 0; i < listNumbers.Count; i++) 
        {
            Debug.Log(listNumbers[i]);

        }


    }


}
