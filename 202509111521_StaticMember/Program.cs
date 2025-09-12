using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509111521_StaticMember
{
    // 정적멤버를 쓰는 이유
    // 유용한 잡다구리한 메소드들...
    class Utility
    {
        public static float add(float a, float b)
        {
            return a + b;
        }

        public static float sub(float a, float b)
        {
            return a - b;
        }

        public static float mul(float a, float b)
        {
            return a * b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 1.2f;
            float b = 3.4f;

            /*
            Utility util = new Utility();
            Console.WriteLine($"{a} + {b} = {util.add(a, b)}");
            */

            Console.WriteLine($"{a} + {b} = {Utility.add(a, b)}");
            Console.WriteLine($"{a} - {b} = {Utility.sub(a, b)}");
        }
    }
}
