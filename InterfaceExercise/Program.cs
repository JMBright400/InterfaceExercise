using System;
using System.Xml.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car
            {
                NumberOfWheels = 4,
                Year = 2017,
                Engine = "V10",
                FuelType = "high-octane",
                TrunkSize = 14,
                PaxCapacity = 2,
                Logo = "Snake",
                Name = "Dodge",
            };

            Truck myTruck = new Truck
            {
                NumberOfWheels = 4,
                Year = 2010,
                Engine = "V6",
                FuelType = "octane",
                BedSize = 73,
                WeightCapacity = 1580,
                Logo = "Ford Logo",
                Name = "Ford",
            };

            SUV mySUV = new SUV
            {
                NumberOfWheels =  4,
                Year = 2023,
                Engine = "V8",
                FuelType = "diesel",
                PayloadCapacity = 1880,
                GroundClearance = 8,
                Logo = "Chevy Emblem",
                Name = "Chevrolet",
            };

            Console.WriteLine($"The {myCar.Year} {myCar.Name} Viper is a powerful vehicle, rockin' a {myCar.Engine} engine that requires {myCar.FuelType} gas.");
            Console.WriteLine($"The Viper has a max passenger capacity of {myCar.PaxCapacity} and a trunk size of {myCar.TrunkSize} inches.");
            Console.WriteLine($"If you've ever heard {myCar.NumberOfWheels} wheels tearing up asphalt, and seen a {myCar.Logo} logo brandished on the hood, odds are likely that was a Viper!");
            Console.WriteLine("");
            Console.WriteLine($"Here we have the {myTruck.Year} {myTruck.Name} Ranger. This is definitely not the largest truck but has proven very reliable.");
            Console.WriteLine($"The Ranger has a bed size of {myTruck.BedSize} inches and can carry a load of {myTruck.WeightCapacity} lbs. It has the {myTruck.Logo} on the steering wheel.");
            Console.WriteLine($"Additionally, the Ranger is equipped with {myTruck.NumberOfWheels} wheels and a {myTruck.Engine} engine that uses regular {myTruck.FuelType} gas.");
            Console.WriteLine("");
            Console.WriteLine($"Who knew they still made an SUV that runs on {mySUV.FuelType}?! That's right, the {mySUV.Year} {mySUV.Name} Tahoe is an all {mySUV.FuelType} machine!");
            Console.WriteLine($"The Tahoe runs on {mySUV.NumberOfWheels} AT tires and a {mySUV.Engine} engine. Other specs include a clearance of {mySUV.GroundClearance} inches and a maximum payload of {mySUV.PayloadCapacity} lbs.");
            Console.WriteLine($"{mySUV.Name} is proud to slap the {mySUV.Logo} on the front of this gas guzzlin' beast!");
        
              
        }
    }
}
