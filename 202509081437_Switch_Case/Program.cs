using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509081437_Switch_Case
{
    internal class Program
    {
        public enum ControlNum
        {
            TVOn,
            TVOff,
            VolumeUp,
            VolumeDown
        };

        static void Main(string[] args)
        {
            int buttonNum = 0;
            Console.WriteLine("버튼 번호를 입력하세요: ");

            buttonNum = Console.Read();

            buttonNum -= 48;

            Console.WriteLine($"{buttonNum}");

            // 정수값의 변화에 따라서 분기시킬때 사용
            switch ((ControlNum)buttonNum) // 선택문
            {
                case ControlNum.TVOn:
                    // int j = 0; X
                    {
                        int i = 0;
                    }
                    Console.WriteLine("TV ON");
                    break;

                case ControlNum.TVOff:
                    Console.WriteLine("TV OFF");
                    break;

                case ControlNum.VolumeUp:
                    Console.WriteLine("Volume Up");
                    break;

                case ControlNum.VolumeDown:
                    Console.WriteLine("Volue Down");
                    break;

                default:    // 생략가능
                    Console.WriteLine("Wrong Number");
                    break;
                  
            }
            /*
            switch (buttonNum) // 선택문
            {
                case 0:
                    Console.WriteLine("TV ON");
                    break;

                case 1:
                    Console.WriteLine("TV OFF");
                    break;

                case 2:
                    Console.WriteLine("Volume UP");
                    break;

                case 3:
                    Console.WriteLine("Volume DOWN");
                    break;

                default: // 생략가능
                    Console.WriteLine("Wrong Number");
                    break;
            }
            */

        }
    }
}
