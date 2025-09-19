using UnityEngine;

namespace Property
{
    //property auto: 자동으로 구현되는 속성 - 필드가 없는 속성
    //트럭의 상태(속성)를 관리하는 클래스: 이름,색상

    public class Truck
    {
        //이름,색상을 property로 구현

        //[1] 필드와 속성을 함께 사용하여 이름을 구현
        //필드
        private string name;
        //property
        public string Name
        {
            get { return name; }  //외부에서 접근해서 읽기
            set { name = value; } //외부에서 접근해서 쓰기
        }

        //[2] 필드없이 속성만 사용하여 색상 구현-자동 구현 속성
        public string Color { get; set; }

        //자동속성은 선언과 동시에 초기화가 가능하다
        public int Number { get; set; } = 1234;


    }
}
