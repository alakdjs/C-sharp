using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021602_StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------
            // Remove() 삭제, Replace() 대치, Insert() 삽입
            string phoneNumber = "010-1234-5689";
            string result = phoneNumber.Remove(3, 4);
            Console.WriteLine(result);

            result = phoneNumber.Remove(3, 4);
            Console.WriteLine(result);

            result = phoneNumber.Replace("-", "_");
            Console.WriteLine(result);

            result = phoneNumber.Insert(3, "(phone)");
            Console.WriteLine(result);
        }
    }
}
