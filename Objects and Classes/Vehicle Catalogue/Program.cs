using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> veihcles = new List<Vehicle>();
            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] commandElements = command.Split();

                Vehicle vehicle = new Vehicle(commandElements[0],commandElements[1],commandElements[2],double.Parse(commandElements[3]));

                veihcles.Add(vehicle);

                command = Console.ReadLine();
            }

            string model;
            while ((model=Console.ReadLine())!= "Close the Catalogue")
            {
                Console.WriteLine(veihcles.FirstOrDefault(x => x.Model == model).ToString());
            }
            //Creates sub-list from veihcles only with cars.
            var cars = veihcles.FindAll(x => x.Type == "car");
            var carHorsePower = cars.Sum(c => c.HorsePower);
            var carAveragePower = carHorsePower / cars.Count;

            var trucks= veihcles.FindAll(x => x.Type == "truck");
            var truckHorsePower = trucks.Sum(t => t.HorsePower);
            var truckAveragePower = truckHorsePower / trucks.Count;

            if (cars.Count==0)
            {
                carAveragePower = 0;
            }
            if (trucks.Count==0)
            {
                truckAveragePower = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {carAveragePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAveragePower:f2}.");
        }
        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

            public Vehicle(string type, string model , string color, double horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }
            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();
                if (this.Type=="car")
                {
                    stringBuilder.AppendLine($"Type: Car");
                }
                else
                {
                    stringBuilder.AppendLine($"Type: Truck");
                }
                
                
                stringBuilder.AppendLine($"Model: {this.Model}");
                stringBuilder.AppendLine($"Color: {this.Color}");
                stringBuilder.AppendLine($"Horsepower: {this.HorsePower}");

                return stringBuilder.ToString().TrimEnd();
            }
        }
    }
}
