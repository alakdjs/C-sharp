using System;

namespace _202509241606_OperatorOverloading_Exer
{
    public class Vector2D
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        // 생성자
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        // 아래 Main에 있는 코드가 작동하도록 연산자 오버로딩 메소드를 만드시고
        // 작동 시켜 보세요...

        // ToString 메서드 오버라이드
        public override string ToString()
        {
            return $"(x = {X}, y = {Y})";
        }

        // 벡터 덧셈
        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        // 벡터 뺄셈
        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
        }

        // 스칼라 곱셈
        public static Vector2D operator *(Vector2D v1, double v2)
        {
            return new Vector2D(v1.X * v2, v1.Y * v2);
        }

        // 스칼라 곱셈
        public static Vector2D operator *(double v1, Vector2D v2)
        {
            return new Vector2D(v1 * v2.X, v1 * v2.Y);
        }

        // 스칼라 나눗셈
        public static Vector2D operator /(Vector2D v1, double v2)
        {
            if(v2 == 0)
            {
                // throw new DivideByZeroException("벡터를 0으로 나눌 수 없음");
                throw new Exception("0으로 나누지 마");
            }

            return new Vector2D(v1.X / v2, v1.Y / v2);

        }
    }

    // 테스트 프로그램 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Vector2D 클래스 테스트 ===\n");

            // 벡터 생성
            Vector2D v1 = new Vector2D(3, 4);
            Vector2D v2 = new Vector2D(1, 2);
            Vector2D v3 = new Vector2D(-2, 1);

            Console.WriteLine($"v1 = {v1}");
            Console.WriteLine($"v2 = {v2}");
            Console.WriteLine($"v3 = {v3}");


            Console.WriteLine("\n=== 벡터 덧셈과 뺄셈 ===");
            Vector2D sum = v1 + v2;
            Console.WriteLine($"{v1} + {v2} = {sum}");

            Vector2D diff = v1 - v2;
            Console.WriteLine($"{v1} - {v2} = {diff}");

            
            Console.WriteLine("\n=== 스칼라 곱셈과 나눗셈 ===");
            Vector2D scaled = v1 * 2.5;
            Console.WriteLine($"{v1} x 2.5 = {scaled}");

            try
            {
                Vector2D divided = v1 / 0;
                Console.WriteLine($"{v1} ÷ 2 = {divided}");
            } catch(DivideByZeroException exception)
            {
                Console.WriteLine($"message : {exception.Message}");
            } catch(Exception exception)
            {
                Console.WriteLine($"message : {exception.Message}");
            }

            Vector2D scaled2 = 3 * v2;
            Console.WriteLine($"3 x {v2} = {scaled}"); 
        }
    }
}
