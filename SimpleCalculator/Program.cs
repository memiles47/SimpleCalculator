using System;

namespace SimpleCalculator
{
    internal static class Program
    {
        private static void Main()
        {
            //Create new person
            var person = new Person();

            //Get age from person
            Console.WriteLine(person.GetAge());

            //Assign new age
            person.SetAge(29);
            Console.WriteLine(person.GetAge());

            //Access static Greeting method
            Person.Greeting();
            Console.ReadKey();
        }
    }
}