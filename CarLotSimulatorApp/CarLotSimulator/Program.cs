using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Bonus
            CarLot luxInv = new CarLot();

            

            Car car1 = new Car();
            car1.Year = 2021;
            car1.Make = "Audi";
            car1.Model = "R8 Spyder";
            car1.EngineNoise = "VROOM";
            car1.HonkNoise = "honk honk";
            car1.IsDriveable = true;

            Car car2 = new Car() { Year = 2021, Make = "Ford", Model = "F-250", EngineNoise = "*gunshots*", HonkNoise = "HOOONK", IsDriveable = true };

            Car car3 = new Car()
            {
                Year = 2021,
                Make = "BMW",
                Model = "3 Series Sedan M",
                EngineNoise = "VROOM",
                HonkNoise = "beep beep",
                IsDriveable = true
            };

            Car car4 = new Car(2021, "BMW", "4 Series Coupe M", "beep beep", "VROOM", true);

            luxInv.luxDealer.Add(car1);
            luxInv.luxDealer.Add(car2);
            luxInv.luxDealer.Add(car3);
            luxInv.luxDealer.Add(car4);


            Console.WriteLine("***LuxDealer Inventory***");
            
            Console.WriteLine($"c");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }

       
    }
}
