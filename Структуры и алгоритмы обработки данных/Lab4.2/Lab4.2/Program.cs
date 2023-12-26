using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Получаем имя файла с текстом для обработки
        Console.Write("Введите имя файла с текстом: ");
        string fileName = Console.ReadLine();

        // Получаем размерность хеш-таблицы
        Console.Write("Введите размерность хеш-таблицы: ");
        int tableSize = int.Parse(Console.ReadLine());

        // Создаем хеш-таблицу
        Dictionary<int, List<string>> hashTable = new Dictionary<int, List<string>>(tableSize);

        // Читаем текст из файла и добавляем слова в хеш-таблицу
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] words = line.Split(' ');

                foreach (string word in words)
                {   
                    int hash = word.GetHashCode() % tableSize;

                    if (!hashTable.ContainsKey(hash))
                    {
                        hashTable.Add(hash, new List<string>());
                    }

                    hashTable[hash].Add(word);
                }
            }
        }

        // Выводим на экран содержимое хеш-таблицы
        Console.WriteLine("Хеш-таблица:");
        foreach (KeyValuePair<int, List<string>> pair in hashTable)
        {
            Console.Write(pair.Key + ": ");

            foreach (string word in pair.Value)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine();
        }

        // Ищем слово в хеш-таблице
        Console.Write("Введите слово для поиска: ");
        string searchWord = Console.ReadLine();

        int searchHash = searchWord.GetHashCode() % tableSize;

        if (hashTable.ContainsKey(searchHash) && hashTable[searchHash].Contains(searchWord))
        {
            Console.WriteLine("Слово найдено в хеш-таблице!");
        }
        else
        {
            Console.WriteLine("Слово не найдено в хеш-таблице.");
        }

        // Удаляем слова, начинающиеся на указанную букву
        Console.Write("Введите букву для удаления слов: ");
        char letter = Console.ReadLine()[0];

        foreach (KeyValuePair<int, List<string>> pair in hashTable)
        {
            pair.Value.RemoveAll(word => word.StartsWith(letter.ToString()));
        }

        // Выводим на экран обновленное содержимое хеш-таблицы
        Console.WriteLine("Хеш-таблица после удаления слов, начинающихся на букву " + letter + ":");
        foreach (KeyValuePair<int, List<string>> pair in hashTable)
        {
            Console.Write(pair.Key + ": ");

            foreach (string word in pair.Value)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
