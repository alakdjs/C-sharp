using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509081721_enCapsulation
{
    // 동사무소에서 필요한 손흥민의 정보는?
    // 주소 나이 이름, 가족관계, 성별, 주민번호

    //대상객체 -> 추상화 -> Data -> class 키워드로 묶음 -> 캡슐화 -> 클래스형 DataType을 만듦. 변수(객체)

    // class 클래스명 {
    //     데이타;
    // }
    class Son   // 캡슐화
    {
        public string address; // 멤버필드
        public int age;
        public string name;
        public bool sungbyul;
        public string juminNum;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 값타입: 기본데이타 타입, 구조체, 열거체
            // (스택영역에 만들어지는 변수로 할당받은 메모리공간의 비트값을 값으로 사용하는 형태)

            // 참조타입: string, 클래스형 DataType, array
            // (동적메모리(Heap)에 값을 저장하는 공간을 할당하고 주소를 참조해서 접근하는 형태)

            // C#에서는 클래스형 DataType 변수(객체)를
            // 값으로 만들수 없습니다.
            // 클래스형 DataType 변수는 동적으로만 만들 수 있습니다.

            Son a = new Son(); // 클래스형 DataType Son으로 객체 a를 만듦.

            a.age = 32;
            a.name = "손흥민";
            a.juminNum = "00000000";
            a.sungbyul = false;
            a.address = "런던";


            Console.WriteLine($"son 나이: {a.age}");
            Console.WriteLine($"son 이름: {a.name}");
            Console.WriteLine($"son 주민번호: {a.juminNum}");
            string sungbyul = a.sungbyul ? "여자" : "남자";
            Console.WriteLine($"son 성별: {sungbyul}");
            Console.WriteLine($"son 주소: {a.address}");


            Console.WriteLine("Hello, World!");
        }
    }
}
