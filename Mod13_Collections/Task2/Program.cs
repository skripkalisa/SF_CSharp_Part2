using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {           
            string text = File.ReadAllText("../../../Text2.txt");
            // Сохраняем символы-разделители в массив
            char[] delimiters = { ' ', '–', '«', '»', '*', '.', '!', '?', ',', ':', ';', '\t', '\"', '\r', '{', '}', '[', ']', '=', '/' , '\n' };
            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);


            var countWords = new Dictionary<string, int>();
            foreach (var word in words)
            {
                var w = word.ToLower();
                countWords.TryAdd(w, 1);
                if(countWords.ContainsKey(w))
                    countWords[w]++;
            }

            var sortedDict = countWords.OrderByDescending(v => v.Value);

            int counter = 0;
            Console.WriteLine("10 most frequent words are: ");
            foreach (var p in sortedDict)
            {
                Console.WriteLine($"{p.Key} \t: {p.Value}");
                counter++;
                if (counter >= 10)
                    break;
            }
        }
        
    }
}