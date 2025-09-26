using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509261643_Collection_Stack_Exer
{
    class BrowserHistory
    {
        private Stack _histroy;

        public BrowserHistory()
        {
            _histroy = new Stack();

            // naveer
            _histroy.Push("www.naver.com");
        }

        public void Visit(string page)
        {
            _histroy.Push(page);
            Console.WriteLine($"현재사이트: {page}");
        }

        public string CurrentPage()
        {
            return _histroy.Peek() as string;
        }

        public int HistoryCount()
        {
            return _histroy.Count;
        }

        public void GoBack()
        {
            if(_histroy.Count > 1)
            {
                string currentPage = _histroy.Pop() as string;
                Console.WriteLine($"이전으로 가기: {currentPage}에서 {CurrentPage()}");
            }
            else
            {
                Console.WriteLine($"이전으로 갈 페이지 없음");
            }

        }

    }

    // 실행
    public class Program
    {
        public static void Main()
        {
            BrowserHistory browser = new BrowserHistory();

            Console.WriteLine($"시작: {browser.CurrentPage()}");
            Console.WriteLine();

            // 여러 사이트 방문
            browser.Visit("google.com");
            browser.Visit("youtube.com");
            browser.Visit("github.com");
            browser.Visit("stackoverflow.com");

            Console.WriteLine($"\n현재 페이지: {browser.CurrentPage()}");
            Console.WriteLine($"방문 기록: {browser.HistoryCount()}개");
            Console.WriteLine();

            // 뒤로가기 여러 번
            browser.GoBack(); // stackoverflow -> github
            browser.GoBack(); // youtube -> google
            browser.GoBack(); // google -> 홈페이지
            browser.GoBack(); // 더 이상 갈 곳 없음

            Console.WriteLine($"\n최종 페이지: {browser.CurrentPage()}");

        }
    }
}
