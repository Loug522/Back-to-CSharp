namespace ConsoleDemo
{
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string VType { get; set; }
        

    public static decimal ReturnVehicleValue(Vehicle vehicle)
        {
            decimal vehicleValue = 20.000M;

            return vehicleValue;
        }
    }
}