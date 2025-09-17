using Electronics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509161652_Inheritance_Exer
{
    // 가전제품 클래스를 만드세요
    // 가전제품 판매점에서 가전제품 관리를 위한 프로그램을 개발하려고 합니다.
    // 1차로 적용되어야 하는 가전제품은 TV, 냉장고, 세탁기입니다.
    // 가전제품이 공통으로 필요한 정보는 높이, 폭, 깊이, 제조년월일, 제작회사명, 중량, 위치정보(A지역 5칸)
    // TV는 화면사이즈, 해상도
    // 냉장고는 용량, 최대 냉각 온도, 전기 사용량
    // 세탁기는 세탁용량, 세탁수조방식(수직형(통돌이), 수평형(트롬))
    // 입니다.
    // 각각의 클래스를 만들고 값을 저장한 후에 출력하시고
    // 상속을 한 후에 컴퓨터를 추가하세요.
    // 각 클래스는 정보를 출력하는 기능
    // 보관되어있는 위치 정보를 출력하는 기능
    // 각 클래스를 따른 파일에 각각 구현 하시고
    // namespace Electronics 안에 구현하세요...

    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television(80.0f, 140.0f, 2.5f, new DateTime(2023, 11, 10), "LG전자", 80.0f, "A동12", 1080, new Rect(1280, 1920));
            WashingMachine washer = new WashingMachine(150.0f, 90.0f, 90.0f, new DateTime(2024, 2, 3), "삼성전자", 60.0f, "B구역 30", 60.0f, WashingMachine.WashingType.Vertical);
            Refrigerator refri = new Refrigerator(180.0f, 70.0f, 60.0f, new DateTime(2023, 10, 10), "LG전자", 100.0f, "C구역8", 890.0f, -28.0f, 50.0f);

            Console.WriteLine($"tv가 있는 위치는 {tv.GetPosition()} 입니다.");
            Console.WriteLine($"washer가 있는 위치는 {washer.GetPosition()} 입니다.");
            Console.WriteLine($"refri가 있는 위치는 {refri.GetPosition()} 입니다.");


            Console.WriteLine();
            tv.Info();
            Console.WriteLine();
            washer.Info();
            Console.WriteLine();
            refri.Info();
        }
    }
}
