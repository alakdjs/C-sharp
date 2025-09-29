using System;
using System.Collections;
using System.Collections.Generic;

namespace Custom
{
    class List<T> : IEnumerator<T>, IEnumerable<T>
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
        private int _count; // 노드 갯수

        public int Count
        {
            get => _count;
        }

        public List()
        {
            _headNode = null;
            _count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = _headNode;

            while (current != null)
            {
                yield return current.Data;

                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = _headNode;

            while (current != null)
            {
                yield return current.Data;

                current = current.Next;
            }
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

            _count++;
        }


        public void RemoveNode(int num)
        {
            // 삭제 할게 없음.
            if (num > _count)
            {
                return;
            }

            if (num == 0)    // 헤드노드 삭제
            {
                Node head = _headNode;
                _headNode = _headNode.Next;

                head.Next = null;
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
            }

            _count--;
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

        Node _currentNode = null;

        public T Current
        {
            get
            {
                return _currentNode.Data;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return _currentNode.Data;
            }
        }

        public bool MoveNext()
        {
            if (_currentNode == null)
            {
                _currentNode = _headNode;
            }
            else
            {
                _currentNode = _currentNode.Next;
            }

            if (_currentNode != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _currentNode = _headNode;
        }

        public void Dispose()
        {

        }
    }

}


namespace _202509261245_Custom_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Custom.List<int> list = new Custom.List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AppendNode(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] =  {list.GetData(i)}");
            }

            Console.WriteLine($"\n");
            list.RemoveNode(2); // 2번째

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] =  {list.GetData(i)}");
            }


            list.InsertNode(2, 10);


            Custom.List<float> flist = new Custom.List<float>();

            for (int i = 0; i < 10; i++)
            {
                flist.AppendNode(i * 1.2f);
            }

            Console.WriteLine("\n");
            for (int i = 0; i < flist.Count; i++)
            {
                Console.WriteLine($"flist[{i}] = {flist.GetData(i)}");
            }

            Console.WriteLine("\n");

            foreach (var data in flist)
            {
                Console.WriteLine(data);
            }


        }
    }
}