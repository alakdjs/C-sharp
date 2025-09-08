using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509081545_Switch_Case_DataType2
{
    class Monster
    {
        public new string ToString()
        {
            return "Monster";
        }
    }

    class Ogre : Monster
    {
        public new String ToString()
        {
            return "Ogre";
        }
    }

    class Golem : Monster
    {
        public new String ToString()
        {
            return "Golem";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            object obj = 123.43;
            obj = "MONster";

            obj = new Monster();

            obj = new Golem();

            obj = new Ogre();
            // c# 9.0
            // switch-case 문에 데이타 형식을 사용가능
            switch (obj)
            {
                case int i:
                    Console.WriteLine($"i = {i}");
                    break;

                case float f when f >= 0:
                    Console.WriteLine($"f = {f}");
                    break;

                case double d:
                    Console.WriteLine($"d = {d}");
                    break;

                case string e:
                    Console.WriteLine($"e = {e}");
                    break;

                case Golem m:
                    Console.WriteLine($"m = {m.ToString()}");
                    break;

                case Ogre j:
                    Console.WriteLine($"j = {j.ToString()}");
                    break;

                case Monster k:
                    Console.WriteLine($"k = {k.ToString()}");
                    break;
            }
        }
    }
}
