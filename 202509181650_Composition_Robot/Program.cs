using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509181650_Composition_Robot
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

    class CannonArmRobot : Robot
    {
        public CannonArmRobot(CannonArm leftArm, CannonArm rightArm)
            : base("캐논암로봇", leftArm, rightArm) { }
    }

    class RocketArmRobot : Robot
    {
        public RocketArmRobot(RocketArm leftArm, RocketArm rightArm)
            : base("로켓암로봇", leftArm, rightArm) { }
    }

    class LaserArmRobot : Robot
    {
        public LaserArmRobot(LaserArm leftArm, LaserArm rightArm)
            : base("레이저암로봇", leftArm, rightArm) { }
    }

    class BombArmRobot : Robot
    {
        public BombArmRobot(BombArm leftArm, BombArm rightArm)
            : base("폭탄암로봇", leftArm, rightArm) { }
    }

    class LightingArmRobot : Robot
    {
        public LightingArmRobot(LightingArm leftArm, LightingArm rightArm)
            : base("번개암로봇", leftArm, rightArm) { }
    }

    class LeftCannonArmRightRocketArmRobot : Robot
    {
        public LeftCannonArmRightRocketArmRobot(CannonArm leftArm, RocketArm rightArm)
            : base("LeftCanonArmRightRocketArmRobot", leftArm, rightArm) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CannonArmRobot cannonArmRobot = new CannonArmRobot(new CannonArm(), new CannonArm());
            RocketArmRobot rocketArmRobot = new RocketArmRobot(new RocketArm(), new RocketArm());
            LaserArmRobot laserArmRobot = new LaserArmRobot(new LaserArm(), new LaserArm());
            BombArmRobot bombArmRobot = new BombArmRobot(new BombArm(), new BombArm());
            LightingArmRobot lightingArmRobot = new LightingArmRobot(new  LightingArm(), new LightingArm());
            LeftCannonArmRightRocketArmRobot leftCannonArmRightRocketArmRobot
                = new LeftCannonArmRightRocketArmRobot(new CannonArm(), new RocketArm());

            cannonArmRobot.Info();
            Console.WriteLine();

            rocketArmRobot.Info();
            Console.WriteLine();

            laserArmRobot.Info();
            Console.WriteLine();

            bombArmRobot.Info();
            Console.WriteLine();

            lightingArmRobot.Info();
            Console.WriteLine();

            leftCannonArmRightRocketArmRobot.Info();
        }
    }
}
