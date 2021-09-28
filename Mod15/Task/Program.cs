﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod15
{
    class Program
    {
        static void Main(string[] args)
        {

            var classes = new []
            {
                new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
                new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
                new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);
         
            Console.WriteLine(string.Join(" ", allStudents));
        }
        static string [] GetAllStudents( Classroom [] classes )
        {
            return classes.SelectMany(c => c.Students).ToArray();
        }

        private class Classroom
        {
            public readonly List<string> Students = new();
        }
    }
}