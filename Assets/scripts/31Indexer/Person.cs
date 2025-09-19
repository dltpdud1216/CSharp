using UnityEngine;

namespace indexer
{
    public class Person
    {
        //필드
        private string name;

        //인덱서 구현 - name 필드의 값을 읽고 쓰는 인덱서
        public string this[int index]
        {
            get
            { 
                return name;
            }
            set
            {
                    name = value;
            }
        }
    }
}
