using System;
using System.Collections;

namespace _202509261242_Collections_Queue_Exer
{
    class BankQueue
    {
        private Queue customers;   // 고객 대기용

        public BankQueue()
        {
            customers = new Queue();
        }

        public void JoinQueue(string customer)
        {
            customers.Enqueue(customer);
            Console.WriteLine($"방금 {customer}가 대기열에 들어갔습니다. 대기자수: {customers.Count}");
        }

        public int WaitingCount()
        {
            return customers.Count;
        }

        public void CallNext()
        {
            if (customers.Count > 0)
            {
                string customerName = customers.Dequeue() as string;
                Console.WriteLine($"다음 {customerName}님 오세요!!");
            }
            else
            {
                Console.WriteLine($"대기 손님이 없습니다");
            }
        }

    }

    // 은행 창구 시스템입니다.
    // Queue를 사용해서 아래 코드가 작동하도록
    // class BankQueue를 만들어보세요...



    public class Program
    {
        public static void Main()
        {
            BankQueue bank = new BankQueue();

            // 대기표를 뽑음.
            bank.JoinQueue("Dragon");
            bank.JoinQueue("Ogre");
            bank.JoinQueue("Goblin");
            bank.JoinQueue("Slime");

            Console.WriteLine($"현재 대기 인원: {bank.WaitingCount()}명");
            Console.WriteLine();

            // 은행원 다음 손님을 호출
            bank.CallNext();
            bank.CallNext();

            Console.WriteLine($"남은 대기 인원: {bank.WaitingCount()}명");
            bank.CallNext();
            bank.CallNext(); // 아무도 없음

            Console.WriteLine($"남은 대기 인원: {bank.WaitingCount()}명");
        }
    }
}
