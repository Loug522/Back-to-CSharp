using System.Text;

namespace ConsoleDemo
{
    
    class BuildingStrings
    {
        public static void StringsBuilder()
        {
            
        /* string myStr = "  Those who seek death shall live, those who seek life shall die   ";
            Console.WriteLine($"Length before: {myStr.Length}\nLength after: {myStr.Trim().Length}"); */


        StringBuilder stringBuilder = new();
            for (var i = 0; i <= 100; i++)
            {
                stringBuilder.Append(" > ");
                stringBuilder.Append(i);
            }
            string result = stringBuilder.ToString();
            
            Console.WriteLine($"{result[3..]}");
        }
    }
}