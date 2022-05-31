using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Akif", "Zakirov", 27);


            Student student1 = new Student("Famil", "Qadirov", "P120")
            {
                Age = 40,
                Point = 1
            };

            Employee employee = new Employee("Samil", "Amilov", "Fehle");

            WarrantyStudent wStudent2 = new WarrantyStudent("Nadir", "Samirov", "P121") 
            { 
                Age = 30,
                PrevGroupNo = "P3000",
                Point = 30


            };

        }
    }
}
