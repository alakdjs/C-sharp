using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051456_Operator7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트 연산자
            int a = 2; // 0000000 00000000 00000000 00000010
            int b = 3; // 0000000 00000000 00000000 00000011
            int c = 0; // 0000000 00000000 00000000 00000000

            // 비트 And
            c = a & b;
            //     a: 00000010
            //     b: 00000011
            // a & b: 00000010
            Console.WriteLine("c = {0}", Convert.ToString(c, 2));

            // 비트 Or
            c = a | b;
            //     a: 00000010
            //     b: 00000011
            // a | b: 00000010
            Console.WriteLine("c = {0}", Convert.ToString(c, 2));

            // 비트 Not
            c = ~a;
            //     a:   00000010
            //    ~a:   11111101
            Console.WriteLine("c = {0}", Convert.ToString(c, 2));

            // 배타적 OR (eXclusive Or)
            c = a ^ b;
            //      a:  00000010
            //      b:  00000011
            //  a ^ b:  00000001
            Console.WriteLine("c = {0}", Convert.ToString(c, 2));
        }
    }
}
