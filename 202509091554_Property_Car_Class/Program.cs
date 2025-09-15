using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509091554_Property_Car_Class
{
    class Car
    {
        private string modelName = ""; // 멤버필드
        private int wheelCount = 4;
        //private int speed;
        private bool isCargo = true;

        public string ModelName
        {
            set { modelName = value; }
            get { return modelName; }
        }

        public int WheelCount
        { get => wheelCount; }

        public int Speed { set; get; } = 10;  // 자동 구현 Property

        public string IsCargo
        {
            get 
            { 
                if (isCargo)
                {
                    return "짐칸있음";
                }
                else
                {
                    return "짐칸없음";
                }
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            // Car 클래스에 멤버필드 각각에 property를 만들고 
            // 값을 저장한 후에 출력해보세요..

            car.ModelName = "포터";
            car.Speed = 200;

            Console.WriteLine($"모델명: {car.ModelName}");
            Console.WriteLine($"바퀴수: {car.WheelCount} 개");
            Console.WriteLine($"최고속도: {car.Speed} km/h");
            Console.WriteLine($"짐칸유무: {car.IsCargo}");
        }
    }
}
