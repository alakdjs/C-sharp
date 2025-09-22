using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster;

namespace _202509221549_Polymorphism_MonsterAttack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dragon dragonA = new Dragon("dragonA", 100, 25, 30);
            Dragon dragonB = new Dragon("dragonB", 100, 29, 27);
            Goblin goblinA = new Goblin("goblinA", 50, 10, 35, 8);
            Goblin goblinB = new Goblin("goblinB", 45, 10, 15, 8);
            Vampire vampireA = new Vampire("vampireA", 20, 10, 30);
            Vampire vampireB = new Vampire("vampireB", 25, 10, 30);

            dragonA.Attack(dragonB);
            dragonB.Info();

            Console.WriteLine();

            goblinA.Attack(goblinB);
            goblinB.Info();

            Console.WriteLine();
            dragonA.Attack(goblinA);
            goblinA.Info();

            Console.WriteLine();
            goblinA.Attack(dragonB);
            dragonB.Info();

            Console.WriteLine();
            vampireA.Attack(dragonB);
            dragonB.Info();
            Console.WriteLine();
            vampireA.Info();

        }
    }
}
