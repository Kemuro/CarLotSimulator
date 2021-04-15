using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car : CarLot
    {
        public Car(int year, string make, string model, string honk, string engine, bool driveable)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.EngineNoise = engine;
            this.HonkNoise = honk;
            this.IsDriveable = driveable;
            numberOfCars++;
        }
        public Car()
        {
            numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public static void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }
        public static void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
