using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509111625_CallByReference
{
    // 메소드 호출될때 인자를 전달하는 방식이
    // 1. call by value
    // 2. call by reference

    // C#
    // 값타입(value Type) 기본데이터타입, 열거체, 구조체
    // 참조타입(refrence type) 클래스, string, array
    
    class A
    {
        public int _value;
        public void Info()
        {
            Console.WriteLine($"_value = {_value}");
        }
    }

    struct B
    {
        public int _bValue;

        public void Info()
        {
            Console.WriteLine($"_bvalue = {_bValue}");
        }
    }

    class Program
    {
        // A Type 인자로 받는 메소드
        // call by reference
        private static void ChangeValue(A value, int num)
        {
            value._value = num;
        }

        // 클래스형 B Type을 인자로 받는 메소드
        // call by value
        private static void ChangeValue(B value, int num)
        {
            value._bValue = num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("클래스형 타입");
            A aa = new A(); // A Type 객체 생성
            aa._value = 100;

            aa.Info();

            ChangeValue(aa, 1000);

            aa.Info();

            Console.WriteLine("구조체 타입");
            B b;
            b._bValue = 200;

            b.Info();

            ChangeValue(b, 1000);

            b.Info();
        }
    }
}
