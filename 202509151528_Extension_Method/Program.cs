using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509151528_Extension_Method
{
    public class Math2 // sealed 키워드로 Math2를 더 이상 상속하지 마...
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }
    }

    // 확장메소드
    public static class Math2Extension
    {
        public static float div(this Math2 myMath, int a, int b)
        {
            return a / (float)b;
        }

        public static float mul(this Math2 myMath, int a, int b)
        {
            return a * (float)b;
        }
    }

    internal class Program
    {
        // 확장메소드
        // 기존 클래스의 기능을 확장하는 기능입니다. (상속이 아닙니다.)
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            Math2 math2 = new Math2();

            float ret = math2.add(a, b);
            Console.WriteLine($"{a} + {b} = {ret}");

            ret = math2.sub(a, b);
            Console.WriteLine($"{a} - {b} = {ret}");

            ret = math2.div(a, b);
            Console.WriteLine($"{a} / {b} = {ret}");

            // Math2 클래스에 mul(곱셈)확장 메소드를 추가하고 
            // 실행해보세요...
            ret = math2.mul(a, b);
            Console.WriteLine($"{a} x {b} = {ret}");
        }
    }
}
