using System.Collections;
using System.IO;
using System.Net;
using MyCodeLibrary;
using System.Linq;

namespace ConsoleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehicles =
            [
                new Vehicle {
                    Make = "infinity",
                    Model = "FX50",
                    Year = 2006,
                    Color = "Purple",
                    VType = "SUV"
                },
                new Vehicle {
                    VType = "Motorcycle"
                },
                new Vehicle {
                    VType = "Boat"
                }
            ];

            // LINQ Query
            /* var cars =  from car in vehicles
                        where car.VType == "SUV"
                        select car;

            foreach (var car in cars)
            {
                Console.WriteLine($"=> {car}");
            } */


            // LINQ Method
            /* var cars2 = vehicles.Where(p => p.Make == "infinity" && p.Year == 2006);

            foreach (var car in cars2)
            {
                Console.WriteLine($"=> {car}");
            } */


            /* var scrape = new Class1();
            string result = scrape.ScrapeWebPage("https://ephinea.pioneer2.net/");
            Console.WriteLine(result); */


            /* int[] myNumArr = { 1, 2, 3, 4, 5 };
            string[] myCharArr = { "a", "b", "c", "d", "e" };
            Console.WriteLine($"{DealingWithArrays.ReturnArray(myCharArr)}"); */


            // Console.WriteLine($"{Vehicle.ReturnVehicleValue(vehicle):C}");
            // Console.WriteLine(vehicle);
            // Console.ReadLine();
            // Console.WriteLine(vehicle1.VType);


            // Console.WriteLine($"{Dates.GetDate()}");
            // BuildingStrings.StringsBuilder();
            // MiniGames.DisplayMenu();
        }
    }
}