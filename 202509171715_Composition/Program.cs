using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509171715_Composition
{
    // 포함
    // Composition: (포함) 강한 결합, 생명주기를 같이함
    // Agreggation: (참조) 약한 결합, 생명주기를 같이 하지 않음..

    class Heart
    {
        private float _purse;
        public Heart()
        {
            Console.WriteLine("Heart 생성자");
        }

        public Heart(float purse)
        {
            _purse = purse;
        }

        public void Check()
        {
            Console.WriteLine($"심장이 정상 작동중입니다.");
        }
    }

    class SmartPhone
    {
        private string _blendName;

        public SmartPhone(string blendName)
        {
            _blendName = blendName;
            Console.WriteLine($"{_blendName} SmartPhone 생성자");
        }

        public void DisPlay()
        {
            Console.WriteLine($"{_blendName} 폰이 정상 작동중입니다.");
        }
    }

    class Human
    {
        const int MAX = 100; // const는 변수를 만듦과 동시에 초기화 가 되어야 합니다.
        public readonly Heart _heart; // readonly 실행 중에 초기화가 될 수 있습니다.
                                      // 초기화가 된 이후 값을 변경할 수 없습니다.

        private SmartPhone _smartPhone; //Agreggation

        public Human(SmartPhone smartPhone)
        {
            Console.WriteLine("Human 생성자");
            _heart = new Heart(70.0f);
            _smartPhone = smartPhone;
        }

        public Human(SmartPhone smartPhone, float purse)
        {
            _heart = new Heart(purse);
            _smartPhone = smartPhone;
        }

        public void CheckHeart()
        {
            _heart.Check();
        }

        public void UsePhone()
        {
            _smartPhone.DisPlay();
        }

        public void ChangePhone(SmartPhone phone)
        {
            _smartPhone = phone;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone samsungPhone = new SmartPhone("SamSung");
            SmartPhone iPhone = new SmartPhone("Apple");

            Human human = new Human(samsungPhone, 70.0f);

            // human._heart = new Heart();
            human.CheckHeart();
            human.UsePhone();

            // 전화기를 바꿈

            human.ChangePhone(iPhone);

            human.UsePhone();

        }
    }
}
