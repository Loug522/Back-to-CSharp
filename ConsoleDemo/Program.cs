namespace ConsoleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new("Infinity", "FX50", 2006, "Purple", "SUV");
            Vehicle vehicle1 = new("Boat");

            // Console.WriteLine($"{Vehicle.ReturnVehicleValue(vehicle):C}");
            Console.WriteLine(vehicle);
            Console.ReadLine();
            Console.WriteLine(vehicle1.VType);
            
            
            
            

            // Console.WriteLine($"{Dates.GetDate()}");
            // BuildingStrings.StringsBuilder();
            // MiniGames.DisplayMenu();
        }
    }
}