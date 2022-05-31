using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isci sayini daxil edin:");
            int count = int.Parse(Console.ReadLine());
            Employee[] arr = new Employee[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1}. Ad daxil edin:");
                arr[i] = new Employee(Console.ReadLine());

                Console.WriteLine($"{i+1}. Yas daxil edin");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine($"{i + 1}. Maas daxil edin");
                int salary = int.Parse(Console.ReadLine());


                Console.WriteLine($"{i + 1}. Pozisiya daxil edin");
                string position = Console.ReadLine();

                
                arr[i].Age = age;
                arr[i].Salary = salary;
                arr[i].Position = position;

            }
            Console.WriteLine("Filterlemek isteyirsinizmi?");
            string filterstr = Console.ReadLine();
            if (filterstr == "yes" || filterstr == "he" || filterstr == "beli")
            {
                Console.WriteLine("Minimum maas daxil edin:");
                int minPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("Maximum maas daxil edin:");
                int maxPrice = int.Parse(Console.ReadLine());
                int counter = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Salary >= minPrice && arr[i].Salary <= maxPrice)
                    {
                        counter++;
                        Console.WriteLine($"Ad: {arr[i].FullName} - Yas: {arr[i].Age} - Pozisiya: {arr[i].Position} - Maas: {arr[i].Salary}");
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine("Bu kriteriyalarda iscimiz yoxdur:)");
                }
            }
            else
            foreach (var item in arr)
            {
                Console.WriteLine($"Ad: {item.FullName} - Yas: {item.Age} - Pozisiya: {item.Position} - Maas: {item.Salary}");
            }

        }
    }
}
