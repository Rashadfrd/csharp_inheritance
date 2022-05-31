using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Employee : Human
    {
        public Employee(string name) : base(name)
        {
        }

        public double Salary;
        public string Position;
    }
}
