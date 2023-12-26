using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Queue
{
    internal class Que
    {
        public class Node<T>    //Узел
        {
            public Node(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public Node<T> Next { get; set; }
        }

        public class Quemy<T>
        {
            public Node<T> Head { get; set; }
            public Node<T> Tail { get; set; }
            int count;

            public int Count
            {
                get { return count; }
            }
            public bool IsEmpty
            {
                get { return count == 0; }
            }
            public void Add(T data)
            {
                Node<T> node = new Node<T>(data);

                if (Head == null)
                    Head = node;
                else
                    Tail.Next = node;
                Tail = node;
                count++;
            }
            public T Take()
            {
                // если стек пуст, выбрасываем исключение
                if (IsEmpty)
                    throw new InvalidOperationException("Стек пуст");
                var node = Head;
                Head = Head.Next;
                count--;
                return node.Data;
            }
            public T Peek()
            {
                return Head.Data;
            }

        }
    }
}
