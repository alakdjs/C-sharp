using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509241520_Operator_Overloading2
{
    class Door
    {
        private bool _isOpen = false;

        public bool isOpen { get => _isOpen; }

        public Door(bool isOpen)
        {
            _isOpen = isOpen;
        }
        /*
        public static implicit operator bool(Door c) // 묵시적 형변환
        {
            return c.isOpen;
        }
        */

        // explicit은 묵시적 형변환을 허용하지 않는다.
        // 명시적 형변환만 허용한다.
        public static explicit operator bool(Door c) // 명시적 형변환
        {
            return c.isOpen;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door(true);

            if(door.isOpen)
            {
                Console.WriteLine("문이 열려있습니다.");
            }
            else
            {
                Console.WriteLine("문이 닫혀있습니다.");
            }

            if((bool)door) // 명시적 형변환
            {
                Console.WriteLine("문이 열려있습니다.");
            }
            else
            {
                Console.WriteLine("문이 닫혀있습니다.");
            }
        }
    }
}
