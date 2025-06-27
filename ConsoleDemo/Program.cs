using System.IO;
using System.Net;
using MyCodeLibrary;

namespace ConsoleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            var scrape = new Class1();
            string result = scrape.ScrapeWebPage("https://ephinea.pioneer2.net/");
            Console.WriteLine(result);
          

            /* int[] myNumArr = { 1, 2, 3, 4, 5 };
            string[] myCharArr = { "a", "b", "c", "d", "e" };
            Console.WriteLine($"{DealingWithArrays.ReturnArray(myCharArr)}"); */


            /* Vehicle vehicle = new("Infinity", "FX50", 2006, "Purple", "SUV");
            Vehicle vehicle1 = new("Boat"); */


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