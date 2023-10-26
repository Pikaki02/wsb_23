using System.Security.AccessControl;

namespace abc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Przeliczanie z l/100km na mile/gallon");
            double litersPer100km = 7.5;
            double milesPerGallon = Engine.ConvertLitersPer100kmToMilesPerGallon(litersPer100km);
            Console.WriteLine($"{litersPer100km} L/100km jest równe {milesPerGallon:F2} mpg");

            Console.WriteLine("Przeliczanie z mile/gallon na l/100km ");
            double milesPerGallon2= 31.36;
            double litersPer100km2 = Engine.ConvertMilesPerGallonToLitersPer100km(milesPerGallon2);
            Console.WriteLine($"{milesPerGallon:F2} mpg jest równe {litersPer100km} L/100km");

            //Engine engine = new Engine();
            //Console.WriteLine(engine.fuelTankCapcity);
            //engine.fuelTankCapcity = 40;


            Engine engine = new Engine(3000, 20);
            Console.WriteLine($"Pojemność silnika {engine.Capacity}, Ilość paliwa {engine.FuelAmount}L, Pojemność baku paliwa {engine.fuelTankCapcity}L");

            Engine engine2 = new Engine(3000, 20, 77);
            Console.WriteLine($"Pojemność silnika {engine2.Capacity}, Ilość paliwa {engine2.FuelAmount}L, Pojemność baku paliwa {engine2.fuelTankCapcity}L");
            
            Car car = new Car();
            car.Go(50);
        }
    }
}