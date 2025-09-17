using UnityEngine;

public class ClassLotto : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //로또 번호 생성구
        //배열 번수 선언 및 요소수 생성

        int[] numbers = new int[6];

        System.Random rand = new System.Random();

        //새로 생성되는 번호
        int number = 0;
        //중복 체크 결과 변수, 중복이면 true, 중복이 아니면 false
        bool flag = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            //1~45번 사이의 랜덤 번호 저장
            number = rand.Next(1, 46);

            //먼저 뽑힌 번호와 비교
            flag = false;
            if(i>0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }
            if(flag==false) //중복이 아닌 경우
            {
                numbers[i] = number;
            }
            else //중복인 경우,인덱스가 증가하면 안된다
            {
                i--;
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]); // 1 ~ 45 범위
        }

    }
}

/*
numbers[0] : x (비교할 대상이 없어  랜덤값 저장

number
numbers[1] : [0] 과 비교
numbers[2] : [0],[1] 과 비교
numbers[3] : [0],[1],[2] 과 비교


*/


/*
//로또 번호 생성기
[1] 6개 번호
[2] 1~45번 사이의 랜덤번호
[3] 중복된 숫자가 나오면 안된다

[1],[2] 구현
1) 임의의 숫자 6개 번호 출력
2) 임의의 정수형 변수에 1~45 랜덤값 저장
3) 중복제거 
*/