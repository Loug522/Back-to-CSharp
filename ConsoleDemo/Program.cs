namespace ConsoleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new();
            vehicle.Make = "Infiniti";
            vehicle.Model = "FX50";
            vehicle.Year = 2006;
            vehicle.Color = "Purple";
            vehicle.VType = "SUV";

            Console.WriteLine($"{Vehicle.ReturnVehicleValue(vehicle):C}");
            Console.WriteLine(vehicle.ToString());
            
            
            

            // Console.WriteLine($"{Dates.GetDate()}");
            // BuildingStrings.StringsBuilder();
            // MiniGames.DisplayMenu();
        }
    }
}