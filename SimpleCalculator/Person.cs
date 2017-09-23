using System;

namespace SimpleCalculator
{
    internal class Person
    {
        private int _age = 25;

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int newAge)
        {
            _age = newAge;
        }

        public static void Greeting()
        {
            Console.WriteLine("Hello!");
        }
    }
}
