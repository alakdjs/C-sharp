using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509301700_Delegate
{
    // Delegate: 대리자

    delegate int Func(int a, int b); // delegate

    class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static int sub(int a, int b)
        {
            return a - b;
        }

        static int mul(int a, int b)
        {
            return a * b;
        }

        static float div(float a,  float b)
        {
            return a / b;
        }

        // 메소드의 참조값을 저장할 수 있는 의미는
        // 다른 메소드의 인자값으로 메소드의 참조값을 전달할 수 있다는 의미입니다.
        static int calculator(Func func, int a, int b)
        {
            return func(a, b);
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            Console.WriteLine($"{a} + {b} = {add(a, b)}");

            Func Add = add;

            int sum = Add(a, b);
            Console.WriteLine($"{a} + {b} = {sum}");

            Add = sub;
            Console.WriteLine($"{a} - {b} = {Add(a, b)}");

            Add = mul;
            Console.WriteLine($"{a} x {b} = {add(a, b)}");

            Console.WriteLine($"{a} - {b} = {calculator(sub, a, b)}");

        }
    }
}
