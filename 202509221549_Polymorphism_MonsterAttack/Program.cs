using Monster;
using System;

namespace _202509221529_Polymorphism_MonsterAttack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dragon dragonA = new Dragon("dragonA", 100, 25, 30);
            Dragon dragonB = new Dragon("dragonB", 100, 29, 27);

            Goblin goblinA = new Goblin("goblinA", 50, 10, 15, 8);
            Goblin goblinB = new Goblin("goblinB", 45, 10, 15, 8);

            Slime slimeA = new Slime("slimeA", 30, 5, 10, 8);

            Zombie zombieA = new Zombie("zombieA", 60, 20, 13);


            dragonA.Attack(dragonB);
            dragonB.Info();

            Console.WriteLine();

            goblinA.Attack(goblinB);
            goblinB.Info();

            Console.WriteLine();
            dragonA.Attack(goblinB);
            goblinB.Info();


            Console.WriteLine();
            goblinA.Attack(dragonA);
            goblinA.Info();

            Console.WriteLine();
            goblinA.Attack(slimeA);
            slimeA.Info();

            Console.WriteLine();
            goblinA.Attack(zombieA);
            zombieA.Info();

        }
    }
}
