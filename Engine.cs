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
        public double FuelAmount { get; set; }
        public double fuelTankCapcity { get; } = 50.0;

        public Engine(double capacity, double fuelAmount)
        {
            this.Capacity = capacity;
            this.FuelAmount = fuelAmount;
            this.fuelTankCapcity = 50.0;
        }
        public Engine(double capacity, double fuelAmount, double fuelTankCapacity) : this(capacity, fuelAmount)
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
            double fuelConsumption = (4 * Capacity * distance) / 100;
            

            if (fuelConsumption > FuelAmount)
                throw new Exception("Brak paliwa");

            FuelAmount -= fuelConsumption;
            

        }
        

    }
}
