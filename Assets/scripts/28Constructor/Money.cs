using UnityEngine;

namespace Constructor
{
    public class Money
    {
        //기본 생성자
        public Money() : this(1000)
        {
            Debug.Log("기본 생성자 실행");
        }

        //매개변수가 있는 생성자 - 매개변수로 받은 골드를 초기 소지금으로 세팅
        public Money(int gold) 
        {
            Debug.Log($"초기 소지금 {gold:#,###}골드를 지급 했습니다");
        }

    }
}