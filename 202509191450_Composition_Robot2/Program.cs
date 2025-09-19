using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509191450_Composition_Robot2
{
    class Arm
    {
        private string _name;

        public Arm(string name)
        {
            _name = name;
        }

        public void Info()
        {
            Console.WriteLine($"{_name}");
        }
    }

    class CannonArm : Arm
    {
        public CannonArm()
            : base("캐논암") { }
    }

    class RocketArm : Arm
    {
        public RocketArm()
            : base("로켓암") { }
    }

    class LaserArm : Arm
    {
        public LaserArm()
            : base("레이저암") { }
    }

    class BombArm : Arm
    {
        public BombArm()
            : base("폭탄암") { }
    }

    class LightingArm : Arm
    {
        public LightingArm()
            : base("번개암") { }
    }

    class Robot
    {
        private string _name;
        private Arm _leftArm;
        private Arm _rightArm;

        public Robot(string name, Arm leftArm, Arm rightArm)
        {
            _name = name;
            _leftArm = leftArm;
            _rightArm = rightArm;
        }

        public void SetLeftArm(Arm leftArm)
        {
            _leftArm = leftArm;
        }

        public void SetRightArm(Arm rightArm)
        {
            _rightArm = rightArm;
        }

        public void Info()
        {
            Console.WriteLine($"-- {_name} --");
            Console.WriteLine("왼쪽팔: ");
            _leftArm.Info();
            Console.WriteLine();
            Console.WriteLine("오른쪽팔: ");
            _rightArm.Info();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Robot cannonArmRobot = new Robot("캐논암로봇", new CannonArm(), new CannonArm());
            Robot rocketArmRobot = new Robot("로켓암로봇", new CannonArm(), new CannonArm());
            Robot bombArmRobot = new Robot("폭탄암로봇", new CannonArm(), new CannonArm());
            Robot lightingArmRobot = new Robot("번개암로봇", new CannonArm(), new CannonArm());
            Robot leftCannonRightRocketArmRobot = new Robot("왼캐논오로켓로봇", new CannonArm(), new RocketArm());

            cannonArmRobot.Info();
            Console.WriteLine();

            rocketArmRobot.Info();
            Console.WriteLine();

            bombArmRobot.Info();
            Console.WriteLine();

            lightingArmRobot.Info();
            Console.WriteLine();

            leftCannonRightRocketArmRobot.SetLeftArm(new BombArm());
        }
    }
}
