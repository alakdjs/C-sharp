using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509111554_ref_out
{
    // 메소드 호출할때 인자를 전달하는 방식이
    // 1. call by value (값에 의한 호출)
    // 2. call by reference (참조에 의한 호출)

    // C#
    // 값티입(Value Type): 기본데이터 타입, 열거체, 구조체
    // 참조타입(Reference Type): class형, DataType, string, array

    // ref, out 키워드는 참조타입으로 인자를 전달할 때 사용.
    // ref로 전달되는 변수는 초기화가 되어있어야 하나 값을 전달하지 않아도 됨.
    // out로 전달되는 변수는 초기화가 되어있지 않아도 되나 값을 반드시 전달해야 함.
    class Program
    {
        static void add(int a, int b, int ret)
        {
            ret = a + b;
        }

        static void addref(int a, int b, ref int ret)
        {
            ret = a + b;
        }

        static void addout(int a, int b, out int ret)
        {
            ret = a + b;
        }

        static void Calculate(int a, int b, out int addValue, out int subValue, out int mulValue)
        {
            addValue = a + b;
            subValue = a - b;
            mulValue = a * b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            int ret = 0;
            int outret;

            add(a, b, ret);
            Console.WriteLine($"{a} + {b} = {ret}");

            addref(a, b, ref ret);
            Console.WriteLine($"{a} + {b} = {ret}");

            addout(a, b, out outret);
            Console.WriteLine($"{a} + {b} = {outret}");

            int addValue;
            int subValue;
            int mulValue;

            Calculate(a, b, out addValue, out subValue, out mulValue);

            Console.WriteLine($"{a} + {b} = {addValue}");
            Console.WriteLine($"{a} - {b} = {subValue}");
            Console.WriteLine($"{a} x {b} = {mulValue}");
        }
    }
}
