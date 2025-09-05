using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051600_Operator_Xor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // xor (exclusive Or 배타적 Or)
            //     a:  1010
            //     b:  1001
            // a ^ b:  0011

            int a = 2; // 00000010
            int b = 3; // 00000011

            // 문제 
            // xor 연산자만 사용해서 다른변수를 만들면 안됩니다.
            // a변수의 값과 b 변수의 값을 바꿔보세요.
            // a변수의 값과 b 변수의 값을 출력하세요.

            a = a ^ b;
            //      a: 00000010
            //      b: 00000011
            //  a ^ b: 00000001 (a)

            b = a ^ b;
            //      a: 00000001
            //      b: 00000011
            //  a ^ b: 00000010 (b)

            a = a ^ b;
            //      a: 00000001
            //      b: 00000010
            //  a ^ b: 00000011 (a)

            Console.WriteLine($"after a = {a}, b = {b}");
        }
    }
}
