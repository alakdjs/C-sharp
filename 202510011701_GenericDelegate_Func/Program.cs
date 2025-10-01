using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510011701_GenericDelegate_Func
{
    delegate float FFunc(float a, float b);
    class Program
    {
        static float add(float a, float b)
        {
            return a + b;
        }

        static float sub(float a, float b)
        {
            return a - b;
        }

        static float mul(float a, float b)
        {
            return a * b;
        }

        static float div(float a, float b)
        {
            return a / b;
        }

        static float calculator(Func<float, float, float> func, float a, float b)
        {
            return func(a, b);
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Func<float, float, float> ffunc;

            // Func : generic delegate는 리턴타입이 있는 경우에 사용합니다.
            Func<int, int, int> func;

            func = add;

            float a = 3.54f;
            float b = 10.53f;

            float ret = calculator(sub, a, b);

            Console.WriteLine($"{a} - {b} = {ret}");

            Console.WriteLine($"{a} x {b} = {calculator(mul, a, b)}");

            Func<int> func1 = () => 10;

            Console.WriteLine(func1());

            Func<int, int> func2 = (int aa) =>
            {
                return aa;
            };

            Console.WriteLine(func2(20));

            // 맨 뒤의 요소가 리턴 타입입니다.
            Func<int, float, float> func3 = (int aa, float bb) =>
            {
                return aa / bb;
            };

            float fret = func3(10, 1.2f);
        }
    }
}
