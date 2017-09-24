using System;

namespace SimpleCalculator
{
    internal static class Program
    {
        private static void Main()
        {
            var person = new Person();

            Console.WriteLine(person.GetAge());
            person.SetAge(29);
            Console.WriteLine(person.GetAge());

            Person.Greeting();
            Console.ReadKey();
        }
    }
}