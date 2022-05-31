using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Student : Human
    {
        public Student(string name, string surname, string groupNo) : base(name, surname)
        {
            this.GroupNo = groupNo;
        }

        public string GroupNo;
        public int Point;
    }
}
