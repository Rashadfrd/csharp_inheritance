using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Human
    {
        public Human(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Human(string name, string surname, byte age) : this(name, surname)
        {
            this.Age = age;
        }

        public string Name;
        public string Surname;
        public byte Age;
    }
}
