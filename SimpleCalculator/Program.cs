﻿using System;

namespace SimpleCalculator
{
    class Program
    {
        //Solution created for course / Learing C# by
        //building applications.
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine(person.GetAge());
            person.SetAge(29);
            Console.WriteLine(person.GetAge());

            Person.Greeting();
            Console.ReadKey();
        }
    }
}