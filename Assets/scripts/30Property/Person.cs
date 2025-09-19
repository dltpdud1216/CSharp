using UnityEngine;

namespace Property
{
    public class Person
    {
        //필드
        private string name; //이름

        //속성(property)을 이용해서 name 필드에 접근 사용
        public string Name
        {
            get { return name; } //읽기
            set { name = value; } //쓰기
        }


        //private한 필드를 public한 메서드를 이용하여 쓰고 읽는다
        public void SetName(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }
    }
}