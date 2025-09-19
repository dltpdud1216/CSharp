using UnityEngine;

namespace Property
{
    public class Student
    {
        //필드
        private string name;
        private string address;

        //속성
     /*   public string Name
        {
            get { return name; }
            set { name = value; }
        }*/

        public string Name
        {
            get => name; //get { return name; }와 동일
            set => name = value; //set { name = value; }와 동일
        }

        //자동 구현 속성
        public int Age { get; set; }

        public int Number { get; set; } = 1;

        //메서드를 이용하여 aderess 읽기,쓰기
        public void SetAddress(string _address)
        {
            this.address = _address;
        }
        public string GetAddress()
        {
            return this.address;
        }
    }
}