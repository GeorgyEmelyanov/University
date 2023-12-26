using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static Lab2.Ll;
using static Lab2.Passanger;

namespace Lab2
{
    internal class Ll
    {
        public class Node<Passanger>    //Узел
        {
            public Node(Passanger data)
            {
                Data = data;
            }
            public Passanger Data { get; set; }
            public Node<Passanger> Next { get; set; }
        }
        public class LinkedListmy<T>   // односвязный список
        {
            public Node<Passanger> Head { get; set; } // головной/первый элемент
            public Node<Passanger> Tail { get; set; } // последний/хвостовой элемент
            int count;  // количество элементов в списке

            // добавление элемента
            public void Add(Passanger data)
            {
                Node<Passanger> node = new Node<Passanger>(data);

                if (Head == null)
                    Head = node;
                else
                    Tail.Next = node;
                Tail = node;
                count++;
            }
            // счетчик элементов
            public int Count { get { return count; } }
            
            // Вывод
            public override string ToString()
            {
                Node<Passanger> curr = Head;
                while (curr != null)
                {
                    Console.Write(curr.Data);
                    curr = curr.Next;
                    Console.WriteLine();
                }
                return "";
            }
            // Сортировка по дате
            public void sort_date()
            {
                var head = Head;
                List<Passanger> list = new List<Passanger>();
                while (head != null)
                {
                    list.Add(head.Data);
                    head = head.Next;
                }

                list.Sort((x, y) => DateTime.Compare(x._date, y._date));
                LinkedListmy<Passanger> new_ll= new LinkedListmy<Passanger>();

                for (int i = 0; i < list.Count; i++) 
                {
                    new_ll.Add(list[i]);
                }
                Clear();
                Head = new_ll.Head;
                Tail = new_ll.Tail;
            }
            // Сортировка по пункту
            public void sort_point()
            {
                var head = Head;
                List<Passanger> list = new List<Passanger>();
                while (head != null)
                {
                    list.Add(head.Data);
                    head = head.Next;
                }

                list.Sort((x, y) => string.Compare(x._point, y._point));
                
                LinkedListmy<Passanger> new_ll = new LinkedListmy<Passanger>();

                for (int i = 0; i < list.Count; i++)
                {
                    new_ll.Add(list[i]);
                }
                Clear();
                Head = new_ll.Head;
                Tail= new_ll.Tail;
            }
            // Поиск по дате
            public string Search_date(DateTime s)
            {
                Node<Passanger> curr = Head;
                while (curr != null)
                {   
                    if (curr.Data._date == s) 
                    {
                        Console.Write(curr.Data);
                        Console.WriteLine();
                    }
                    curr = curr.Next;
                }
                return "";
            }
            // Поиск по пункту
            public string Search_point(string s)
            {
                Node<Passanger> curr = Head;
                while (curr != null)
                {
                    if (curr.Data._point == s)
                    {
                        Console.Write(curr.Data);
                        Console.WriteLine();
                    }
                    curr = curr.Next;
                }
                return "";
            }
            // Масса выше допустимой
            public string tooHeavy(double s)
            {
                Node<Passanger> curr = Head;
                while (curr != null)
                {
                    if (curr.Data._bag_weigth > s)
                    {
                        Console.Write(curr.Data);
                        Console.WriteLine();
                    }
                    curr = curr.Next;
                }
                return "";
            }
            // очистка списка
            public void Clear()
            {
                Head = null;
                Tail = null;
                count = 0;
            }
        }
    }
}
