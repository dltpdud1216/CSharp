using UnityEngine;

// 2개의 수를 입력 받아 그 중 큰 수를 출력한다
public class GreatgerThanEqual : MonoBehaviour
{
    public int first = 0;
    public int second = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 입력받은 first와 second 값을 비교하여 큰 값 출력
        // 만약 first가 second이상이면 first 출력
        if (first >= second)
        {
            Debug.Log($"큰 값은 : {first}");
        }
        else
        {
            Debug.Log($"큰 값은 : {second}");

        }
    }

  
}
