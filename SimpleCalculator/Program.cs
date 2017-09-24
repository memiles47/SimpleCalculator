using System;

namespace SimpleCalculator
{
    internal static class Program
    {
        // And why am I doing this??
        // Because I love her.
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