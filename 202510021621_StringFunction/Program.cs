using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021621_StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // startWith(), EndsWith();

            string[] id = { "A123", "B213", "A456", "B456" };

            foreach (var item in id)
            {
                if (item.StartsWith("B"))   // B로 시작하는 문자열
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            foreach (var item in id)
            {
                if (item.EndsWith("56")) // 56으로 끝나는 문자열.
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
