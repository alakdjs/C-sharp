using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509111502_GlobalData
{
    // 정적멤버를 어느 경우에 사용하나?
    // 범용성 있는 Data를 쉽게 접근하게 하려고

    class A
    {
        public int _stage;

        public void SetStage()
        {
            _stage = GlobalData.Stage;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            GlobalData.Stage = 10;
            A a = new A();
            a.SetStage();

            Console.WriteLine($"Global = {GlobalData.Stage}"); 
        }
    }
}
