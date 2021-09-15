using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = File.ReadAllText("../../../Text1.txt");
            // Сохраняем символы-разделители в массив
            char[] delimiters = { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            var watchOne = Stopwatch.StartNew();
            var textToList = new List<string>(words);
            Console.WriteLine($"List<T> time: {watchOne.Elapsed.TotalMilliseconds}  мс");

            var watchTwo = Stopwatch.StartNew();
            var textToLinkedList = new LinkedList<string>(words);
            Console.WriteLine($"LinkedList<T> time: {watchTwo.Elapsed.TotalMilliseconds}  мс");

        }
    }
}