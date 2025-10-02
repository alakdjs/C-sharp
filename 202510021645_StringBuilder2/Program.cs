using System;
using System.Diagnostics;
using System.Text;


namespace _202510021645_StringBuilder2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "안녕";
            string Text2 = Text;
            Console.WriteLine($"Text = {Text}");
            Console.WriteLine($"Text2 = {Text2}");
            Console.WriteLine($"Text2 == Text {Object.ReferenceEquals(Text, Text2)}");

            Text2 = "hello";

            Console.WriteLine($"Text = {Text}");
            Console.WriteLine($"Text2 = {Text2}");
            Console.WriteLine($"Text2 == Text {Object.ReferenceEquals(Text, Text2)}");

            Console.Read();
            Stopwatch regularStopwatch = new Stopwatch();
            regularStopwatch.Start();

            string test = "";

            for (int i = 0; i < 100000; i++)
            {
                test += $"monster{i}";
            }
            regularStopwatch.Stop();

            //Console.WriteLine($"test = {test}");

            Console.WriteLine($"String Regular StopWatch: {regularStopwatch.ElapsedMilliseconds / 1000.0f} sec");
            //Console.Write($"Start Any Input: ");
            //Console.Read();

            Stopwatch BuilderStopWatch = new Stopwatch();
            BuilderStopWatch.Start();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 1000000; i++)
            {
                sb.Append($"monster{i}");
            }

            BuilderStopWatch.Stop();

            //Console.WriteLine($"sb = {sb}");

            Console.WriteLine($"String Builder Regular StopWatch: {BuilderStopWatch.ElapsedMilliseconds / 1000.0f} sec");
        }
    }
}
