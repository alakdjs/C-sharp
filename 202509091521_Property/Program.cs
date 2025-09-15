using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509091521_Property
{
    // 동사무소에서 필요한 손흥민의 정보는?
    // 주소 나이 이름, 가족관계, 성별, 주민번호

    // 객체지향 설명!!
    //대상객체 -> 추상화 -> Data -> class 키워드로 묶음 -> 캡슐화 -> 클래스형 DataType을 만듦. 변수(객체)

    // class 클래스명 {
    //     데이타;
    // }


    // 접근제어자
    // 객체안에 멤버에 접근을 허용하거나 허용하지 않거나 하는 것을 접근제어자라고 합니다.
    // 갭슐화의 기본 정책은 정보은닉
    // private: 외부에서 접근하는 것을 허용하지 않음, 자식이 접근하는 것도 허용하지 않음( 기본)
    // protected: 자식이 접근하는 것은 허용, 외부에서 접근하는 것은 허용하지 않음
    // public: 외부에서 접근하는 것을 허용하겠다.

    class Son // 캡슐화
    {
        private string address = ""; // 멤버필드
        private int age;
        private string name = "";
        private bool sungbyul;
        private string juminNum = "";

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // property를 사용할때의 장점
        // 1. 데이타의 무결성(정확성, 일관성, 유효성)
        // 2. 디버깅 작업이 용이함.

        public int Age
        {
            get => age;
            set
            {
                if (value < 1)
                {
                    age = 1;
                }
                else if (value > 200)
                {
                    age = 200;
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public bool SungByul
        {
            get => sungbyul;
            set => sungbyul = value;
        }

        public string JuminNum
        {
            get
            {
                return juminNum;
            }

            set => juminNum = value;
        }

    }

    // 멤버필드를 직접 접근하는 것을 허용하지 말라고 합니다. (권고사항)
    // property를 통해서 접근하도록 해라...

    internal class Program
    {
        static void Main(string[] args)
        {

            // 값타입: 기본데이타 타입, 구조체, 열거체 (스택영역에 만들어지는 변수로 할당받은 메모리공간의 비트값을 값으로 사용하는 형태)
            // 참조타입: string, 클래스형 DataType, array (동적메모리(Heap)에 값을 저장하는 공간을 할당하고 주소를 참조해서 접근하는 형태)


            // C#에서는 클래스형 DataType 변수(객체)를
            // 값으로 만들수 없습니다.
            // 클래스형 DataType 변수는 동적으로만 만들 수 있습니다.
            Son a = new Son(); // 클래스형 DataType Son으로 객체 a를 만듦.
            a.Age = 32;
            a.JuminNum = "00000000";
            a.SungByul = false;
            a.Address = "런던";

            a.Age = 400;

            Console.WriteLine($"son 나이: {a.Age}");
            Console.WriteLine($"son 이름: {a.Name}");
            Console.WriteLine($"son 주민벊: {a.JuminNum}");
            string sungbyul = a.SungByul ? "여자" : "남자";
            Console.WriteLine($"son 성별: {sungbyul}");
            Console.WriteLine($"son 주소: {a.Address}");
        }
    }
}
