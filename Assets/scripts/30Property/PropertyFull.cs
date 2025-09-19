using UnityEngine;

namespace Property
{

    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 인스턴스 생성
            Person person = new Person();
            //Private필드 접근(에러- 보호수준)
            //person.name = "홍길동"; 

            //속성 이용하여 private한 필드에 접근
            person.Name = "홍길동"; //쓰기
            Debug.Log(person.Name); //읽기

            //메서드를 이용하여 private한 필드에 쓰기읽기
            person.SetName("백두산");
            Debug.Log(person.GetName()); //읽기


        }
    }
    
}
