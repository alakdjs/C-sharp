using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509151720_BoxingUnBoxing
{
    // Boxing, UnBoxing

    // 값타입(value type) : 기본 데이터 타입(string 제외), 구조체, 열거체
    // 참조타입(reference type) : string, class, array

    class A
    {
        public int _value;

        public void Print()
        {
            Console.WriteLine($"_value = {_value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;

            object obj = 20; // boxing

            object obj2 = i; // boxing

            int j = (int)obj; // UnBoxing
        }
    }
}
