using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021705_FileInput_Output2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 파일을 C:\\Save 폴더가 있는 지 확인하고
            // 있으면 해당폴더에 Test.txt 파일이 있는 확인한 후에
            // 파일을 읽도록 수정하세요.
            if (Directory.Exists("C:\\Save") && File.Exists("C:\\Save\\Test.txt"))
            {
                FileStream fileStream = 
                    new FileStream("C:\\Save\\Test.txt", FileMode.Open, FileAccess.Read);

                StreamReader streamReader = new StreamReader(fileStream);

                //string strData = streamReader.ReadLine();
                string strData = streamReader.ReadToEnd();

                Console.WriteLine($"strData = {strData}");

                streamReader.Close();
            }
            else
            {
                Console.WriteLine("해당 Path가 없습니다.");
            }
        }
    }
}
