using UnityEngine;

public class SwitchNote2 : MonoBehaviour
{
    public int answer = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (answer)
        {
            case 1:
                Debug.Log("1번을 선택했습니다"); //실행문 [2]
                break;

            case 2:
                Debug.Log("2번을 선택했습니다"); //실행문 [3]
                break;
            case 3:
                Debug.Log("3번을 선택했습니다"); //실행문 [3]
                break;

            case 4:
                Debug.Log("4번을 선택했습니다"); //실행문 [3]
                break;

            default:
                Debug.Log("잘못 선택했습니다");
                break;

        }
      
    }


}

/* 
 * [Q]
 * 입력받은 수를 판별하여 
 * 1-1번을 선택했습니다 출력
 * 2-2번을 선택했습니다 출력
 * 3-3번을 선택했습니다 출력
 * 4-4번을 선택했습니다 출력
 * 다른 수면 잘못 선택했습니다
 */    

    // Update is called once per frame