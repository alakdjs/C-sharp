using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509041507_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("monster ");  // 줄바꿈 X
            Console.WriteLine("is a World!"); // 줄바꿈 O

            Console.WriteLine(string.Format("bool\t size: {0} byte", sizeof(bool)));
            Console.WriteLine("char\t size: {0} byte", sizeof(char));
            Console.WriteLine("sbyte\t size: " + sizeof(sbyte) + " byte");
            Console.WriteLine($"ushort\t size: {sizeof(int)} byte");
            Console.WriteLine($"uint\t size: {sizeof(uint)} byte");
            Console.WriteLine($"long\t size: {sizeof(long)} byte");
            Console.WriteLine($"ulong\t size: {sizeof(ulong)} byte");
            Console.WriteLine($"float\t size: {sizeof(float)} byte");
            Console.WriteLine($"double\t size: {sizeof(double)} byte");
            Console.WriteLine($"decimal\t size: {sizeof(decimal)} byte");
        }
    }
}
