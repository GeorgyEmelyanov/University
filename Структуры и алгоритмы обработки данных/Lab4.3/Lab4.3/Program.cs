using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Получаем имя файла с числами для обработки
        Console.Write("Введите имя файла с числами: ");
        string fileName = Console.ReadLine();

        // Создаем хеш-таблицу
        Dictionary<int, List<string>> hashTable = new Dictionary<int, List<string>>();

        // Читаем числа из файла и добавляем числа в хеш-таблицу
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(' ');

                foreach (string value in values)
                {
                    int hash = value.GetHashCode();

                    if (!hashTable.ContainsKey(hash))
                    {
                        hashTable.Add(hash, new List<string>());
                    }

                    hashTable[hash].Add(value);
                }
            }
        }

        // Выводим на экран содержимое хеш-таблицы
        Console.WriteLine("Хеш-таблица:");
        foreach (KeyValuePair<int, List<string>> pair in hashTable)
        {
            Console.Write(pair.Key + ": ");

            foreach (string value in pair.Value)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }

        // Ищем число в хеш-таблице
        Console.Write("Введите число для поиска: ");
        string searchValue = Console.ReadLine();

        int searchHash = searchValue.GetHashCode() ;

        if (hashTable.ContainsKey(searchHash) && hashTable[searchHash].Contains(searchValue))
        {
            Console.WriteLine("Число найдено в хеш-таблице!");
        }
        else
        {
            Console.WriteLine("Число не найдено в хеш-таблице.");
        }
        Console.ReadLine();
    }
}
