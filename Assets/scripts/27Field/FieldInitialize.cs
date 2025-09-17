using UnityEngine;
using Field;

namespace Field //namespace가 Field로 using으로 가져오지 않아도 Field사용 가능
{ 
public class FieldInitialize : MonoBehaviour
    {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //say클래스의 인스턴스 생성
            Say say = new Say();

            say.Hi();
    
        }

    
    }
}