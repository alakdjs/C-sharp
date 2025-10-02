using System;
using System.IO;
using System.Text;

namespace _202510021700_FileInputOutput1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("C:\\Save"))
            {
                Console.WriteLine("해당 Path가 있습니다.");
            }
            else
            {
                Console.WriteLine("해당 디렉토리가 없습니다. 디렉토리를 생성합니다.");

                Directory.CreateDirectory("C:\\Save");
            }

            FileStream fileStream = new FileStream("C:\\Sava\\Text.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8);

            string strData = "여러분 안녕하세요. !!!";
            int intData = 12314;
            float floatData = 1.23f;

            writer.Write(strData);
            writer.Write(intData);
            writer.Write(floatData);

            writer.Close();
            fileStream.Close();
        }
    }
}
