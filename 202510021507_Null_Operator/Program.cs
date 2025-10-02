using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021507_Null_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ??= 널대입연산자
            List<int> numbers = null;
            int? a = null;

            // 왼쪽의 피연산자가 null로 계산되는 경우에만 오른쪽 피연산자의 값을 
            // 왼쪽 피연산자에 대입합니다.
            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));

            numbers.Add(a ??= 0);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(a);

            int? c = 10;

            numbers.Add(c ??= 30);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(c);

            // null 병합연산자
            int? bb = null;
            Console.WriteLine($"b ?? 10 : {bb ?? 10}");

            int? cc = 100;
            Console.WriteLine($"b ?? 10 : {cc ?? 10}");

            int? num = null;
            Console.WriteLine($"{num ?? 0}");

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");

            string str2 = "Specific";
            Console.WriteLine($"{str2 ?? "Default"}");

            int[] numArray = new int[] { 1, 2, 3 };

            // Null 조건부 인덱스 연산자
            int? nb = numArray?[0];

            Console.WriteLine($"nb = {nb}");
            numArray = null;
            nb = numArray?[0];
            Console.WriteLine($"nb = {nb}");
        }
    }
}
