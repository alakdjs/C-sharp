using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051544_Operator_light
{
    class Program
    {
        // & (비트 AND) : 특정자리에 비트 값을 0으로 만들때 사용 (Mask Off)
        // | (비트 Or) : 특정자리에 비트 값을 1로 만들때 사용 (Mask on)
        static void BitPrint(int value)
        {
            int mask = 1;
            int bitValue = 0;

            for (int i = sizeof(int) * 8 - 1; i >= 0; i--)
            {
                mask = 1;
                mask <<= i;

                bitValue = value & mask;

                if (bitValue > 0)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
            }
        }
        static void Main(string[] args)
        {
            int light = 0;      // 00000000
            int roomNumber = 0; // 방번호 입력용
            int onOff = -1;     // light on/off 입력용

            int mask = 1;       // 비트의 자리수를 컨트롤하기 위한 변수

            while (true)
            {
                mask = 1;
                Console.Write("방번호를 입력하세요(exit: -1) : ");
                string numStr = Console.ReadLine();
                roomNumber = Convert.ToInt32(numStr); // 3

                if (roomNumber == -1)
                    break;    // 입력중지

                Console.Write("{0}번째 방의 전등 On(1), 전등 Off(0): ", roomNumber);
                numStr = Console.ReadLine();
                onOff = Convert.ToInt32(numStr); // 0

                mask <<= roomNumber;
                // mask : 00000001
                // mask << 3: 00001000

                if (onOff == 1)
                {
                    // 전등 켜기 // maskOn
                    light = light | mask;
                    // 00000000
                    // 00001000
                    // 00001000
                }
                else
                {
                    mask = ~mask;
                    light = light & mask;
                }

                Console.WriteLine($"light = {light}");
                BitPrint(light);
                Console.WriteLine();
            }
        }
    }
}
