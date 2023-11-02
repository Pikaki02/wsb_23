using System.Security.AccessControl;

namespace abc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Przeliczanie z l/100km na mile/gallon");
            double litersPer100km = 7.5;
            double milesPerGallon = Engine.ConvertLitersPer100kmToMilesPerGallon(litersPer100km);
            Console.WriteLine($"{litersPer100km} L/100km jest równe {milesPerGallon:F2} mpg");

            Console.WriteLine("Przeliczanie z mile/gallon na l/100km ");
            double milesPerGallon2 = 31.36;
            double litersPer100km2 = Engine.ConvertMilesPerGallonToLitersPer100km(milesPerGallon2);
            Console.WriteLine($"{milesPerGallon:F2} mpg jest równe {litersPer100km} L/100km");

            //Engine engine = new Engine();
            //Console.WriteLine(engine.fuelTankCapcity);
            //engine.fuelTankCapcity = 40;


            Engine engine = new Engine(3000, 20);
            Console.WriteLine($"Pojemność silnika {engine.Capacity}, Ilość paliwa {engine.FuelAmount}L, Pojemność baku paliwa {engine.fuelTankCapcity}L");

            Engine engine2 = new Engine(3000, 20, 77);
            Console.WriteLine($"Pojemność silnika {engine2.Capacity}, Ilość paliwa {engine2.FuelAmount}L, Pojemność baku paliwa {engine2.fuelTankCapcity}L");

            Car car = new Car("Fiat", "126p", 0.65, 25, 42);
            Console.WriteLine($"Marka: {car.Brand}, model: {car.Model},\n pojemność silnika: {car.Engine.Capacity}, ilość paliwa: {car.Engine.FuelAmount}, pojemność zbiornika: {car.Engine.fuelTankCapcity}.");
            
            car.Go(25);
            Console.WriteLine($"Ilość paliwa: {car.Engine.FuelAmount}");
            car.Refuel(10);
            Console.WriteLine($"Ilość paliwa: {car.Engine.FuelAmount}");*/
            Symulator();
        }
        public static void Symulator()
        {
            Console.WriteLine("Podaj parametry Auta:");
            Console.WriteLine("Podaj marke samochodu:");
            string brand = Console.ReadLine();
            Console.WriteLine("Podaj model samochodu:");
            string model = Console.ReadLine();
            Console.WriteLine("Podaj pojemność silnika (w litrach):");
            double capacity = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilość paliwa w baku (w litrach):");
            double fuelAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pojemność zbiornika na paliwo (w litrach):");
            double fuelTankCapacity = double.Parse(Console.ReadLine());
            Car car = new Car(brand,model, capacity, fuelAmount, fuelTankCapacity);

            while (true)
            {
                Console.WriteLine("1 - Jedź\n" +
                                    "2 - Tankuj\n" +
                                    "3 - Ile mam paliwa\n"+
                                    "4 - Pokaż parametry samochodu\n"+
                                    "5 - Wyjście z programu\n");
                int choice = int.Parse(Console.ReadLine()); 
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Podaj dystans do przejechania (w km):");
                        int distance = int.Parse(Console.ReadLine());
                        car.Go(distance);
                        break;
                    case 2:
                        Console.WriteLine("Podaj ilość paliwa do zatankowania (W litrach):");
                        double fuelToAdd = double.Parse(Console.ReadLine());
                        car.Refuel(fuelToAdd);
                        break;
                    case 3:
                        Console.WriteLine($"Ilość paliwa w baku: {car.Engine.FuelAmount}");
                        break;
                    case 4:
                        car.showCar();
                        break;
                    case 5:
                        Console.WriteLine("Koniec programu");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        break;
                }

               
            }
        }
    }
}