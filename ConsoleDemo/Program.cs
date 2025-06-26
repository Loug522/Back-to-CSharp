using System.IO;
using System.Net;

namespace ConsoleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] myNumArr = { 1, 2, 3, 4, 5 };
            string[] myCharArr = { "a", "b", "c", "d", "e" };
            Console.WriteLine($"{DealingWithArrays.ReturnArray(myCharArr)}");


            /* WebClient client = new();
            string reply = client.DownloadString("https://www.google.com");        
            File.WriteAllText("C:/Users/User/OneDrive/바탕 화면/CSharp/.git/Back-to-CSharp/ConsoleDemo/Test.txt", reply); */


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