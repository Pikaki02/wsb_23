using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class Engine
    {
        public double Capacity { get; set; }
        public  double FuelAmount {  get; set; }
        public double fuelTankCapcity { get; } = 50.0;
        
        public Engine(double capacity, double fuelAmount) 
        {
            this.Capacity = capacity;
            this.FuelAmount = fuelAmount;
            this.fuelTankCapcity = 50.0;
        }
        public Engine(double capacity, double fuelAmount, double fuelTankCapacity) : this(capacity,fuelAmount)
        {
            this.fuelTankCapcity = fuelTankCapacity;
        }
        public double FuelTankCapacity()
        {
            return fuelTankCapcity;
        }
        public static double ConvertLitersPer100kmToMilesPerGallon(double liters)
        {
            return 235.214583 / liters;
        }
        public static double ConvertMilesPerGallonToLitersPer100km(double gallons)
        {
            return 235.214583 * gallons;
        }


        public void Work(int distance)
        {
            double fuelConsumption = (4 * Capacity) / 1000;

            if (fuelConsumption >= FuelAmount)
            {
                FuelAmount = fuelConsumption * distance;
                Console.WriteLine($"Jestem. Pozostałe paliwo {FuelAmount}L");
            }
            else
            {
                Console.WriteLine("Brak paliwa");
                FuelAmount = 0;
            }
                    
        }

    }
}
