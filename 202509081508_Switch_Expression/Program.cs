using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509081508_Switch_Expression
{
    internal class Program
    {
        public static string GetGrade(int score)
        {
            switch (score)
            {
                case 90:
                    return "A";

                case 80:
                    return "B";

                case 70:
                    return "C";

                case 60:
                    return "D";

                default:
                    return "F";
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int score = (int)(Math.Truncate(input / 10.0f) * 10);

            string grade = GetGrade(score);

            Console.WriteLine($"grade = {grade}");

            Console.WriteLine("추가 점수를 주시겠습니까, (1(true), 0(false))?");

            bool appenScore = false;

            int num = Console.Read();

            num -= 48;

            if(num == 0)
            {
                appenScore = false;
            }
            else
            {
                appenScore = true;
            }

            // switch 식
            grade = score switch
            {
                90 when (appenScore) => "A+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F" // default;
            };

            Console.WriteLine($"grade = {grade}");
        }
    }
}
