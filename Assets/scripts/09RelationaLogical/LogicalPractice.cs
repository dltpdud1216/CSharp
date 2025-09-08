using UnityEngine;

public class LogicalPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j != 3); // 참
        Debug.Log($"r: {r}"); 

        r = (i != 3) || (j == 3); // 거짓
        Debug.Log($"r: {r}");

        r = (i >= 5); // 거짓
        Debug.Log($"r: {r}");

        Debug.Log((1==1)||(1!=1)); //참
        Debug.Log(!(1 == 1)); //거짓
    }

  
}
