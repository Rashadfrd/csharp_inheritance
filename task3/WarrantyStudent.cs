using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class WarrantyStudent : Student
    {
        public WarrantyStudent(string name, string surname, string groupNo) : base(name, surname, groupNo)
        {

        }
        public string PrevGroupNo;
    }
}
