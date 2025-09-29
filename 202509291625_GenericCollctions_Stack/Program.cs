using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509291625_GenericCollctions_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Start");

            for(int i = 0; i < 10; i++)
            {
                stack.Push($"Data {i}");
            }

            Console.WriteLine();
            Console.WriteLine($"peek {stack.Peek()}");
            Console.WriteLine();

            foreach(var data in stack)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();

            while (stack.Count > 0)
            {
                Console.WriteLine($"{stack.Pop()}");
            }

            foreach(var data in stack)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine();
        }
    }
}
