using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//만약 score가 60이상이면 "합격"이라고 출력
public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //만약 조건식이 참이면 {} 실행문을 실행하라
        /*  if(Score 60 이상);
          {
              "합격"이라고 출력
          }*/

        int score = 60;

        /*  //조건식이 참이면 코드 블록 안에 있는 실행문을 실행한다
          if (score >= 60)
          {
              //실행문
              Debug.Log("합격");
    }*/
        //단문(실행문1), 복문(실행문 2개이상)

        //단문 예제
        if (score == 1)
        { Debug.Log("단문 1");
        }
        //if 문에서 {} 생략되면 if문 바로 밑에 있는 명령문을 참일때 실행
        //if문 바로 밑에 있는 명령문 하나만 if문 실행문이 된다
        if (1 == 1)
            Debug.Log("단문 2");

        if (1 == 1) Debug.Log("단문 3");

        //복문 (실행문 2개 이상)
        if(1 == 1)
        {
            Debug.Log("복문1");
            Debug.Log("복문2");
        }
    }

   
}
/*
 if(조건문)
조건식이 참일 때만 실행문이 실행된다
조건식이 거짓이면 실행문이 실해하지 않는다.

만약 조건식이 참이면 {} 실행문을 실행하라
if(조건식)
{// 실행문1
//실행문2
//...
}

if(bool)
 */