using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509041649_Operator3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 증감연산자
            // ++, --
            int a = 20;
            int c = 0;

            ++a; // 전치형
            // a = a + 1;
            Console.WriteLine($"a = {a}");

            a++; // 후치형
            // a = a + 1;
            Console.WriteLine($"a = {a}");

            c = ++a;
            // a = a + 1;
            // c = a;
            Console.WriteLine($"c = ++a, c = {c} , a = {a}");

            c = a++;
            // c = a;
            // a = a + 1;
            Console.WriteLine($"c = a--, c = {c}, a = {a}");


            // --

            a--;
            // a = a - 1;

            --a;
            // a = a - 1;

            c = --a;
            // a = a - 1;
            // c = a;

            c = a--;
            // c = a;
            // a = a - 1;
        }
    }
}
