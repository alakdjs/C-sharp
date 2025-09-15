using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _202509151540_Extension_Method;

namespace _202509151540_Extension_Method
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result = result * myInt;

            return result;
        }
    }

    public static class FloatExtension
    {
        public static float Square(this float myInt)
        {
            return myInt * myInt;
        }
    }

    // double형 확장 메소드 Square
    public static class DoubleExtension
    {
        public static double Square(this double myInt)
        {
            return myInt * myInt;
        }
    }

    // string형 문자열을 매개변수에 전달된 횟수만큼 출력하는 확장메소드
    public static class StringExtension
    {
        public static void Print(this string myStr, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{myStr}");
            }
        }
    }
}


namespace ExtensionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{3}^2 : {3.Square()}");
            Console.WriteLine($"{3}^{4} : {3.Power(4)}");
            Console.WriteLine($"{2}^{10} : {2.Power(10)}");

            Console.WriteLine($"{3.14}^2 : {(3.14f).Square()}");
            Console.WriteLine($"{10.11}^2 : {(10.11).Square()}"); // Double Square

            ("monster").Print(10); // String
        }
    }
}