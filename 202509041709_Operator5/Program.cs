using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509041709_Operator5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("논리연산자");
            // 논리연산자
            // &&(논리And), || (논리OR), !(논리 Not)

            // 논리 And(그리고)
            // 논리 And 연산자는 false 확률이 높은 것을 앞에 위치시키는 것이
            // 유리합니다.
            bool ret = true && true;
            Console.WriteLine($"true && true = {ret}");
            ret = true && false;
            Console.WriteLine($"true && false = {ret}");
            ret = false && true;
            Console.WriteLine($"false && true = {ret}");
            ret = false && false;
            Console.WriteLine($"false && false = {ret}");

            // 논리 Or(또는)
            // 논리 Or 연산자는 true 확률이 높은 것을 앞쪽에 놓는 것이 유리합니다.
            ret = true || true;
            Console.WriteLine($"true || true = {ret}");
            ret = true || false;
            Console.WriteLine($"true || false = {ret}");
            ret = false || true;
            Console.WriteLine($"false || true = {ret}");
            ret = false || false;
            Console.WriteLine($"false || false = {ret}");

            // 논리 not
            ret = !true;
            Console.WriteLine($"!true = {ret}");
            ret = !false;
            Console.WriteLine($"!false = {ret}");
        }
    }
}
