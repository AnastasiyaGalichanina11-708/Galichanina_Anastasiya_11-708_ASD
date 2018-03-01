using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лексикографический_порядок
{

    class Program
    {
        static void Main(string[] args)
        {
            var listWord = new List<string>();
            string word = "a";
            while (word != " ") //заполняем массив слов, которые хотим отсортировать
            {
                word = Console.ReadLine();
                listWord.Add(word);
            }
            int length = word.Length;
            int k = listWord.Count;

            for (int i = length-1; i >= 0; i--)//проходимся по словам от последней буквы, до 1
            {
                var sort = new Dictionary<char, List<string>>();// создаём карман где char- нужная нам буква
                foreach (var e in listWord)
                {
                    if (!sort.ContainsKey(e[i])) // Если ещё нет кармана с данной буквой, то иы его создаём
                    {
                        sort[e[i]] = new List<string>();
                    }
                    sort[e[i]].Add(e); // заполняем карман новым словом
                }
                listWord.Clear();
                foreach (var e in sort.Keys)
                    listWord.AddRange(sort[e]);  
            }
            foreach (var e in listWord)
                Console.WriteLine(e);// Осталось отсортировать ключи в алфавитном порядке
        }
    }
}

