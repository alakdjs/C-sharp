using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509111535_StaticMember_Singleton
{
    // Singleton 패턴은 프로젝트를 통틀어서 객체가 하나만 만들어지도록 제한할 때 사용.
    // 유니티에서 보통 manager를 만들때 사용.(SoundManager, DataManager, SceneManager등)

    public sealed class Singleton
    {
        private static Singleton _instance = null;

        // private 생성자로 외부에서 인스턴스 생성 방지
        private Singleton()
        {
            Console.WriteLine("Singleton instance created");
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton is working...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Singleton singleton = new Singleton();

            Singleton.Instance.DoSomething();
        }
    }
}
