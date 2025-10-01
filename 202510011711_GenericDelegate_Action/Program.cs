using System;
using static System.Console;

namespace _202510011711_GenericDelegate_Action
{
    class Program
    {
        static void add(float a, float b)
        {
            WriteLine($"{a} + {b} = {a + b}");
        }

        static void add(float a, float b, int c)
        {
            WriteLine($"{a} + {b} + {c} = {a + b + c}");
        }

        static void add(int a, float b, double c)
        {
            WriteLine($"{a} + {b} + {c} = {a + b + c}");
        }

        static void calculator(Action<float, float> func, float a, float b)
        {
            func(a, b);
        }


        static void Main(string[] args)
        {
            Action<float, float, int> func;

            // Action : generic delegate 리턴값이 없는 경우에 사용
            Action act1 = () => WriteLine("Action");

            Action<float, float> act2;

            act2 = add;
            act2(12.3f, 20.3f);

            Action<float, float, float> printFloat = (float a, float b, float c) =>
            {
                WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
            };

            printFloat(2.3f, 3.4f, 5.5f);
        }
    }
}
