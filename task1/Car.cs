using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Car : Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;

        public void AddFuel()
        {
            Console.WriteLine("Elave etmek istediyiniz benzinin miqdarini qeyd edin:");
            int addedFuel = int.Parse(Console.ReadLine());
            if (addedFuel + CurrentFuel <= FuelCapacity)
            {
                CurrentFuel += addedFuel;
            }
            else
                Console.WriteLine("Limit asildi!");

        }

        public void ShowInfo()
        {
            Console.WriteLine($" Brand: {Brand} - Nodel: {Model} - Millage: {Millage} - FuelCapacity: {FuelCapacity} - CurrentFuel: {CurrentFuel}");
        }

    }


}
