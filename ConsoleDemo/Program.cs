using System.Collections;
using System.IO;
using System.Net;
using MyCodeLibrary;

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

            foreach (Vehicle item in vehicles)
            {
                Console.WriteLine($"=> {item.VType}");
            }           

            
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