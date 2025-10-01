using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510011548_Delegete_Chain
{
    delegate void CalChain(int a, int b);

    // delegate chain: delegate에 여러 개의 함수를 연결해서 일괄적으로 처리할때 사용.

    class Program
    {
        static void add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        static void sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        static void mul(int a, int b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        static void div(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {a / (float)b}");
        }

        static void Main(string[] args)
        {
            // delegate chain
            CalChain cal =
                (CalChain)Delegate.Combine(
                    new CalChain(add),
                    new CalChain(sub),
                    new CalChain(mul)
                );

            cal(200, 300);
            Console.WriteLine();
            cal += div;

            cal(20, 30);

            cal -= div;

            Console.WriteLine();

            cal(20, 30);
        }
    }
}
