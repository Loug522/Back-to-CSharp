namespace ConsoleDemo
{
    class Dates
    {

        public static string GetDate()
        {
            DateTime myBday = DateTime.Parse("10/23/1992");
            TimeSpan myAge = DateTime.Now.Subtract(myBday);

            return $"{myAge.TotalDays:.} days.";
        }
        
    }
}