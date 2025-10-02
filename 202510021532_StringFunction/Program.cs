using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021532_StringFunction
{
    // String Funtion
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열분리
            string str = "I Love a C# Language!!/I Love a C++ Language!!/I Love a Java Language!!";

            string[] strArray = str.Split('/');

            for(int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }

            // 부분 문자열
            string substr = strArray[0].Substring(3);
            Console.WriteLine(substr);

            substr = strArray[0].Substring(2, 4);

            Console.WriteLine($"{substr}");

            // 문자열 비교
            string str2 = "Car";
            string str3 = "Car";

            int compare = str2.CompareTo("Car"); // 비교문자열 같으면 0, 다르면 1 이나 -1

            switch (compare)
            {
                case 0:
                    Console.WriteLine("두 문자열이 같습니다.");
                    break;

                case 1:
                case -1:
                    Console.WriteLine("두 문자열이 다릅니다.");
                    break;
            }

            bool isSame = str3.Equals(str2); // true, false

            if(isSame)
            {
                Console.WriteLine("두 문자열이 같습니다.");
            }
            else
            {
                Console.WriteLine("두 문자열이 다릅니다.");
            }

            // Replace
            string str4 = "apple mango banana pineapple";
            str4 = str4.Replace("apple", "berry");

            Console.WriteLine($"str4 = {str4}");

            for(int i = 0; i < str4.Length; i++)
            {
                Console.Write($"{str4[i]}");
            }

        }
    }
}
