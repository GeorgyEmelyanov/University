using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Mass
{
    public static class Extensions                          // Метод добавления элемента в массив
    {
        public static T[] Append<T>(this T[] array, T item)
        {
            if (array == null)                             // Если массив не имеет элементов, то возвращается новый массив с начальным нулевым элементом
            {
                return new T[] { item };
            }
            T[] result = new T[array.Length + 1];         // Создание нового массива с количеством элементов +1;
            array.CopyTo(result, 0);                      // Копирование входящего массива
            result[array.Length] = item;                  // В конец скопированного (конечного) массива добавляется новый элемент
            return result;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов N: ");  // Задание и считывание N
            int N = 0;                                  
            int.TryParse(Console.ReadLine(), out N);    

            int[] arr0 = { };                           // Создание массива

            // Считывание N целочисленных элементов 
            Console.WriteLine("Введите N целочисленных элементов исходного массива");
            for (int i=0; i<N; i++)
            {
                int arg = Convert.ToInt32(Console.ReadLine());
                if (arg % 2 == 0)                       // Если число четное, то добавляем его в конечный массив
                    arr0 = arr0.Append(arg);
            }

            Console.WriteLine("Конечный массив: ");     // Вывод конечного массива 
            if (arr0.Length == 0)
                Console.WriteLine("нет четных элементов в исходном массиве.");
            else
            for (int i = 0; i< arr0.Length; i++)       
            {
                Console.WriteLine(arr0[i]);
            }
        }
    }
}
