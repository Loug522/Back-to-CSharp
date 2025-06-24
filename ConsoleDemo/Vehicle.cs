namespace ConsoleDemo
{
    class Vehicle
    {
        public Vehicle(string vehicleType)
        {
            VType = vehicleType;
        }

        public Vehicle(string make, string model, int year, string color, string vtype)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            VType = vtype;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string VType { get; set; }

        

        public static decimal ReturnVehicleValue(Vehicle vehicle)
        {
            decimal vehicleValue;

            if (vehicle.Year > 2000)
                vehicleValue = 10000;
            else
                vehicleValue = 5000;
            return vehicleValue;
        }

        public override string ToString()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nColor: {Color}\nVehicle type: {VType}";
        }
    }
}