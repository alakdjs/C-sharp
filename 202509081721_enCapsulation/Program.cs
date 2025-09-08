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
        public string address;
        public int age;
        public string name;
        public bool sungbyul;
        public string juminNum;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Son a = new Son();  // 클래스형 DataType Son으로 객체 a를 만들었음.

            Console.WriteLine("Hello, World!");
        }
    }
}
