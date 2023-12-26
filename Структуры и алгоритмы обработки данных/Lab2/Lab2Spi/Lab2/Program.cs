using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static Lab2.Ll;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2035, 7, 20, 18, 30, 25);
            Passanger pers1 = new Passanger(1235123, date, "Астрахань", "Иванов", 6, 10);
            DateTime date1 = new DateTime(2025, 9, 20, 18, 30, 25);
            Passanger pers2 = new Passanger(77823, date1, "Ростов", "Емельянова", 7, 18);
            DateTime date2 = new DateTime(2045, 7, 20, 18, 30, 25);
            Passanger pers3 = new Passanger(923423, date2, "Челябинск", "Петров", 3, 12);
            DateTime date3 = new DateTime(2055, 9, 20, 18, 30, 25);
            Passanger pers4 = new Passanger(502453, date3, "Саратов", "Сергеев", 2, 2);


            LinkedListmy<Passanger> linkedList = new LinkedListmy<Passanger>();

            linkedList.Add(pers1);
            linkedList.Add(pers2);
            linkedList.Add(pers3);
            linkedList.Add(pers4);

            
            Console.WriteLine("Исходный список");
            Console.WriteLine(linkedList.ToString());
            
            // Сортировка по дате вылета
            Console.WriteLine();
            Console.WriteLine("Сортировка по дате вылета ");
            linkedList.sort_date();
            Console.WriteLine(linkedList.ToString());

            // Сортировка по пункту назначения
            Console.WriteLine();
            Console.WriteLine("Сортировка по пункту назначения ");
            linkedList.sort_point();
            Console.WriteLine(linkedList.ToString());

            // Поиск по дате
            Console.WriteLine();
            Console.WriteLine("Поиск по дате ");
            Console.WriteLine(linkedList.Search_date(new DateTime(2025, 9, 20, 18, 30, 25)));

            // Поиск по пункту назначения
            Console.WriteLine();
            Console.WriteLine("Поиск по пункту назначения ");
            Console.WriteLine(linkedList.Search_point("Астрахань"));

            // Масса выше допустимой
            Console.WriteLine();
            Console.WriteLine("Масса выше допустимой ");
            Console.WriteLine(linkedList.tooHeavy(3));
        


        }
    }
}
