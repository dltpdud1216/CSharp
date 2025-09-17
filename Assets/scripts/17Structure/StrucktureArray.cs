using UnityEngine;

//[1] 구조체 정의,선언
//고객 데이터 관리하는 구조체
struct BusinessCard
{
    public string name; //문자열 name이라는 구조체 생성
    public int age; //정수형 age라는 구조체 생성
}

public class StrucktureArray : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 구조체 사용 - 구조체 변수 선언
        BusinessCard biz;
        //구조체 변수들 초기화

        biz.name = "홍길동";
        biz.age = 20;

        //구조체 변수 사용
        PrintBusinessCard(biz.name, biz.age);
        PrintBusinessCard(biz);

        //[3] 구조체 사용 - 구조체 배열 변수 선언, 배열의 요소수 생성(크기 결정)
        BusinessCard[] bizCards = new BusinessCard[2];

        //배열 구조체 변수들 초기화
        bizCards[0].name = "백두산";
        bizCards[0].age = 25;

        bizCards[1].name = "임꺽정";
        bizCards[1].age = 30;

        //구조체 변수들 사용
        for (int i = 0; i < bizCards.Length; i++)
        {
           /* PrintBusinessCard(bizCards[i].name, bizCards[i.age]);*/
            PrintBusinessCard(bizCards[i]);
        }



    }
    //고객 정보를 출력하는 함수
    void PrintBusinessCard(string irum, int nai)
    {
        Debug.Log($"{irum} 고객님의 나이는 {nai}살 입니다");
    }

    //고객 정보를 출력하는 함수 - 2
    void PrintBusinessCard(BusinessCard card)
    {
        Debug.Log($"이름: {card.name}, 나이 : {card.age}");
    }

}
