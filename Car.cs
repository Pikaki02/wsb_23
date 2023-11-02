using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }

        public Car(string brand, string model, Engine engine)
        {
            this.Brand = brand;
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string brand, string model, double capacity, double fuelAmount)
        {
            this.Brand = brand;
            this.Model = model;
            this.Engine.Capacity = capacity;
            this.Engine.FuelAmount = fuelAmount;
        }
        public Car(string brand, string model, double capacity, double fuelAmount, double fuelTankCapacity)
        {
            this.Brand= brand;
            this.Model = model;
            this.Engine = new Engine(capacity,fuelAmount,fuelTankCapacity);

        }
        public void Go(int distance)
        {
            Console.WriteLine("Jade");

            Thread.Sleep((distance * 100));

            Engine.Work(distance);

        }
        public void Refuel(double fuelAmount)
        {

            if (Engine.FuelAmount + fuelAmount > Engine.fuelTankCapcity)
                throw new Exception("Chcesz zatankować za dużo paliwa.");
            
                Engine.FuelAmount += fuelAmount;
           
        }
        public void showCar()
        {
            Console.WriteLine($"Marka: {this.Brand}, model: {this.Model},\n pojemność silnika: {this.Engine.Capacity}, ilość paliwa: {this.Engine.FuelAmount}, pojemność zbiornika: {this.Engine.fuelTankCapcity}.");
        }
    }
}
