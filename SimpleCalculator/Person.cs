using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Person
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
