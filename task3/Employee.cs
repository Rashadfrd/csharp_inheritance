using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Employee : Human
    {
        public Employee(string name, string surname, string position) : base(name, surname)
        {
            Position = position;
        }

        public string Position;
        public double Salary;
    }
}
