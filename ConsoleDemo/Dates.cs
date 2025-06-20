namespace ConsoleDemo
{
    class Dates
    {

        public static string GetDate()
        {
            DateTime myBay = DateTime.Parse("10/23/1992");
            TimeSpan myAge = DateTime.Now.Subtract(myBay);

            return $"{myAge.TotalDays:.} days.";
        }
        
    }
}