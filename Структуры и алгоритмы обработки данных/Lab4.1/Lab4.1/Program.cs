using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Введите строку");
            var s= Console.ReadLine();

            foreach ( var i in s )
            {
                if (ht.ContainsKey(i))
                    ht[i] =(int) ht[i] + 1;
                else
                    ht.Add(i, 1);
            }
            Console.WriteLine("Исходная таблица");
            foreach ( var i in ht.Keys ) 
            {
                Console.WriteLine(i.ToString() + " = "  +  ht[i]);
            }
            Console.WriteLine("Введите символ для поиска в хеш-таблице");
            char value = Convert.ToChar(Console.Read());

            if (ht.ContainsKey(value))
            {
                Console.WriteLine("Искомый символ: " + value + " = " + ht[value]);
            }
            else
                Console.WriteLine("Введенный символ не содержится в таблице");
        }
    }
}
