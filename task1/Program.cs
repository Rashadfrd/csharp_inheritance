using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Brand = "Porsche",
                Millage = 10000,
                Model = "Panamera",
                FuelCapacity = 100,
                CurrentFuel = 45
            };
            car1.ShowInfo();
            car1.AddFuel();
            car1.ShowInfo();

        }
    }
}
