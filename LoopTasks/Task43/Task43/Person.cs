using System;
using System.Collections.Generic;
using System.Text;

namespace Task43
{
    class Person
    {
        public string firstName;
        public string lastName;

        string GetName()
        {
            return $"{firstName} - {lastName}";
        }

        public void PrintName()
        {
            Console.WriteLine(GetName());
        }
    }
}
