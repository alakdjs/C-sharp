using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    class List<T>
    {
        class Node
        {
            private Node _next;
            public Node Next
            {
                set { _next = value; }
                get { return _next; }
            }

            private T _data;
            public T Data
            {
                get { return _data; }
                set { _data = value; }
            }

            public Node(T data)
            {
                _data = data;
            }
        }

        private Node _headNode; // 헤드노드의 주소값을 저장
        private int _count;     // 노드 개수
        public int Count
        {
            get { return _count; }
        }

        public List()
        {
            _headNode = null;
            _count = 0;
        }

        public void InsertNewHead(T data)
        {
            if (_headNode == null)
            {
                _headNode = new Node(data);
            }
            else
            {
                Node n = new Node(data);
                n.Next = _headNode;
                _headNode = n;
            }

            _count++;
        }

        public void AppendNode(T data)
        {
            if (_headNode == null)
            {
                _headNode = new Node(data);
            }
            else
            {
                Node head = _headNode;

                while (head.Next != null)
                {
                    head = head.Next;
                }

                head.Next = new Node(data);
            }

            _count++;
        }

        public void InsertNode(int num, T data)
        {
            // 리스트의 노드의 갯수보다 num이 큰거나 같은 경우 Append 처리한다.
            if (num >= _count)
            {
                AppendNode(data);
            }
            else
            {
                Node current = _headNode;
                while (num > 0)
                {
                    current = current.Next;
                    num--;
                }

                Node node = new Node(data);

                node.Next = current.Next;
                current.Next = node;
            }
        }

        public void RemoveNode(int num)
        {
            // 삭제 할 게 없음.
            if (num > _count)
            {
                return;
            }

            if (num == 0) // 헤드 노드 삭제
            {
                Node head = _headNode;
                _headNode = _headNode.Next;

                head.Next = null;
                _count--;
            }
            else
            {
                Node current = _headNode;
                num--; // num번째 노드를 삭제해야함.

                // num번째 이전노드를 찾는다.
                while (num > 0)
                {
                    current = current.Next;
                    num--;
                }

                Node remove = current.Next;
                current.Next = remove.Next;
                remove.Next = null;
                _count--;
            }
        }

        public T GetData(int num)
        {
            Node current = _headNode;

            // num번째 이전노드를 찾는다.
            while (num > 0)
            {
                current = current.Next;
                num--;
            }

            return current.Data;
        }
    }
}

namespace _202509291452_Custom_LinkedList
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Custom.List<int> list = new Custom.List<int>();

            for(int i = 0; i < 10; i++)
            {
                list.AppendNode(i);
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"list[{i}] = {list.GetData(i)}");
            }

            Console.WriteLine("\n삭제");

            list.RemoveNode(2); // 2번째

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = {list.GetData(i)}");
            }

            Console.WriteLine("\n삽입");

            list.InsertNode(2, 10);
            
            for(int i = 0; i < list.Count; i ++)
            {
                Console.WriteLine($"list[{i}] = {list.GetData(i)}");
            }

        }
    }
}
