using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509051533_Operator_mask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트 And (&) // MaskOff: 특정자리의 비트값을 0으로 만드는 것
            // 비트 Or(|)   // MaskOn: 특정자리의 비트값을 1로 만들때

            int Item = 10;  // 00001010
            int mask = 1;

            mask <<= 3;
            mask = ~mask;

            // Item: 00001010
            // mask: 00001000
            // ~mask: 11110111

            Item = Item & mask;
            //         Item:  00001010
            //         mask:  11110111
            // Item & mask :  00000010
            Console.WriteLine($"a = {Convert.ToString(Item, 2)}");

            mask = 1;
            mask <<= 3;
            Item = Item | mask;
            //       Item:   00000010
            //       mask:   00001000
            // Item | mask:  00001010
            Console.WriteLine($"a = {Convert.ToString(Item, 2)}");

        }
    }
}
