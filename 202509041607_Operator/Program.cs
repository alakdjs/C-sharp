using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509041607_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 수식연산자
            // +, -, *, /, %
            int a = 1;
            int b = 2;
            int ret = 0;

            ret = a + b; // 정수 + 정수 = 정수
            Console.WriteLine($"{a} + {b} = {ret}");

            ret = a - b; // 정수 - 정수 = 정수
            Console.WriteLine($"{a} - {b} = {ret}");

            ret = a * b; // 정수 x 정수 = 정수
            Console.WriteLine($"{a} * {b} = {ret}");

            ret = a / b; // 정수 / 정수 = 정수
            Console.WriteLine($"{a} / {b} = {ret}");

            float fret = a / b;
            Console.WriteLine($"{a} / {b} = {fret}");

            fret = a / (float)b;
            Console.WriteLine($"{a} / {b} = {fret}");

        }
    }
}
