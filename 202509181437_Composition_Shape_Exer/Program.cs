using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _202509181437_Composition_Shape_Exer
{
    class Point
    {
        private int _x, _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point(Point pt)
        {
            _x = pt._x;
            _y = pt._y;
        }

        public int X
        {
            get => _x;
        }

        public int Y
        {
            get => _y;
        }

        public void Info()
        {
            Console.WriteLine($"x : {_x}, y: {_y}");
        }
    }

    class Line
    {
        private readonly Point _pt1, _pt2;

        public Line(int pt1x, int pt1y, int pt2x, int pt2y)
        {
            _pt1 = new Point(pt1x, pt1y);
            _pt2 = new Point(pt2x, pt2y);
        }

        public Line(Point pt1, Point pt2)
        {
            _pt1 = new Point(pt1);
            _pt2 = new Point(pt2);
        }

        public float GetLength()
        {
            int xBase = _pt2.X - _pt1.X;
            int height = _pt2.Y - _pt1.Y;

            return (float)Math.Sqrt(Math.Pow(xBase, 2) + Math.Pow(height, 2));
        }
    }

    // 삼각형클래스 (정삼각형, 직각삼각형)
    // 사각형 클래스 (정사각형, 직각사각형)
    // 원 클래스

    // 각각의 도형클래스를 만들고 면적을 계산하는 메서드를 추가하여
    // 각각의 도형객체의 면적을 구하세요..

    class Triangle
    {
        private readonly Point _pt1, _pt2, _pt3;

        public Triangle(int pt1x, int pt1y, int pt2x, int pt2y, int pt3x, int pt3y)
        {
            _pt1 = new Point(pt1x, pt1y);
            _pt2 = new Point(pt2x, pt2y);
            _pt3 = new Point(pt3x, pt3y);
        }

        public float GetArea()
        {
            int Base = _pt1.X - _pt2.X;
            int height = _pt1.Y - _pt3.Y;

            return (float)Base * height / 2; 
        }
    }

    class Rectangle
    {
        private readonly Point _pt1, _pt2, _pt3;

        public Rectangle(int pt1x, int pt1y, int pt2x, int pt2y, int pt3x, int pt3y)
        {
            _pt1 = new Point(pt1x, pt1y);
            _pt2 = new Point(pt2x, pt2y);
            _pt3 = new Point(pt3x, pt3y);
        }

        public float GetArea()
        {
            int Base = _pt1.X - _pt2.X;
            int height = _pt1.Y - _pt3.Y;

            return (float)Base * height;
        }
    }

    class Circle
    {
        private readonly Point _center, _line;

        public Circle(int cx, int cy, int lx, int ly)
        {
            _center = new Point(cx, cy);
            _line = new Point(lx, ly);
        }

        public float GetArea()
        {
            float r = (float)Math.Sqrt(Math.Pow((_line.X - _center.X), 2) + Math.Pow((_line.Y - _center.Y), 2));

            return (float)3.14 * r * r;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(0, 0, 4, 4);
            Console.WriteLine($"line Length = {line.GetLength()}");

            Triangle triangle = new Triangle(0, 0, 3, 3, 3, 9);
            Console.WriteLine($"triangle = {triangle.GetArea()}");

            Rectangle rectangle = new Rectangle(0, 0, 3, 4, 4, 8);
            Console.WriteLine($"rectangle = {rectangle.GetArea()}");

            Circle circle = new Circle(0, 0, 4, 4);
            Console.WriteLine($"circle = {circle.GetArea()}");
        }
    }
}

/*
namespace _202509171233_Composition_Shape_Exer
{
   
   class Point
   {
      private int _x, _y;

      public Point(int x, int y)
      {
         _x = x;
         _y = y;
      }

      public Point(Point pt)
      {
         _x = pt._x;
         _y = pt._y;
      }

      public int X
      {
         get => _x;
      }

      public int Y
      {
         get => _y;
      }

      public void Info()
      {
         Console.WriteLine($"x: {_x}, y: {_y}");
      }

   }

   class Line
   {
      private readonly Point _pt1, _pt2;

      public Line(int pt1x, int pt1y, int pt2x, int pt2y)
      {
         _pt1 = new Point(pt1x, pt1y);
         _pt2 = new Point(pt2x, pt2y);
      }

      public Line(Point pt1, Point pt2)
      {
         _pt1 = new Point(pt1);
         _pt2 = new Point(pt2);
      }

      public float GetLength()
      {
         int xBase = _pt2.X - _pt1.X;
         int height = _pt2.Y - _pt1.Y;

         return (float)Math.Sqrt(Math.Pow(xBase, 2) + Math.Pow(height, 2));
      }
   }

   // 삼각형클래스 (정삼각형, 직각삼각형)
   // 사각형 클래스 (정사각형, 직각사각형)
   // 원 클래스

   // 각각의 도형클래스를 만들고 면적을 계산하는 메서드를 추가하여
   // 각각의 도형객체의 면적을 구하세요..

   class Triangle
   {
      private readonly Point _topPt, _leftBottomPt, _rightBottomPt;

      public Triangle(int topPtX, int topPtY, int leftBottomPtX, int leftBottomPtY, int rightBottomPtX, int rightBottomPtY)
      {
         _topPt = new Point(topPtX, topPtY);
         _leftBottomPt = new Point(leftBottomPtX, leftBottomPtY);
         _rightBottomPt = new Point(rightBottomPtX, rightBottomPtY);
      }

      public Triangle(Point topPt, Point leftBottomPt, Point rightBottomPt)
      {
         _topPt = new Point(topPt);
         _leftBottomPt = new Point(leftBottomPt);
         _rightBottomPt = new Point(rightBottomPt);
      }

      public float GetArea()
      {
         int xBase = _rightBottomPt.X - _leftBottomPt.X;
         int height = _rightBottomPt.Y - _topPt.Y;

         return xBase * height / 2;
      }      

   }

   class Rectangle
   {
      private readonly Point _leftTopPt, _rightBottomPt;

      public Rectangle(int leftTopPtX, int leftTopPtY, int rightBottomPtX, int rightBottomPtY)
      {
         _leftTopPt = new Point(leftTopPtX, leftTopPtY);
         _rightBottomPt = new Point(rightBottomPtX, rightBottomPtY);
      }

      public Rectangle(Point leftTopPt, Point rightBottomPt)
      {
         _leftTopPt = new Point(leftTopPt);
         _rightBottomPt = new Point(rightBottomPt);
      }

      public float GetArea()
      {
         int xBase = _rightBottomPt.X - _leftTopPt.X;
         int yBase = _rightBottomPt.Y - _leftTopPt.Y;

         return xBase * yBase;
      }

   }

   class Cycle
   {
      private readonly Point _centerPt;
      private float _radius;

      private const float PI = 3.14f;

      public Cycle(int centerPtX, int centerPtY, int radius)
      {
         _centerPt = new Point(centerPtX, centerPtY);
         _radius = radius;
      }

      public Cycle(Point centerPt, int radius)
      {
         _centerPt = new Point(centerPt);
         _radius = radius;
      }

      public Cycle(Point centerPt, Point arcPt)
      {
         _centerPt = new Point(centerPt);

         Line line = new Line(centerPt, arcPt);

         _radius = line.GetLength();
      }

      public Cycle(int centerPtX, int centerPtY, int arcPtX, int arcPtY)
      {
         _centerPt = new Point(centerPtX, centerPtY);

         Line line = new Line(centerPtX, centerPtY, arcPtX, arcPtY);

         _radius = line.GetLength();
      }

      public float GetArea()
      {
         return PI * _radius * _radius;
      }

   }


   internal class Program
   {
      static void Main(string[] args)
      {
         Line line = new Line(0, 0, 4, 4);

         Console.WriteLine($"line Lenght = {line.GetLength()}");

         Triangle tri = new Triangle(4, 4, 2, 2, 4, 2);

         Console.WriteLine($"tri Area = {tri.GetArea()}");

         Rectangle rect = new Rectangle(2, 2, 4, 4);
         Console.WriteLine($"rect Area = {rect.GetArea()}");

         Cycle cycle = new Cycle(0, 0, 4, 4);

         Console.WriteLine($"cycle Area = {cycle.GetArea()}");
      }
   }
} 
 
 */