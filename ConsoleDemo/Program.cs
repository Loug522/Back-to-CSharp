namespace ConsoleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            string myStr = "Neun Welten";
            char[] charArr = myStr.ToCharArray();
            Array.Reverse(charArr);
            foreach (char charItem in charArr)
            {
                Console.Write($"{charItem}");
            }
            

            /* string[] namesArr = new string[] { "Haejoon", "Eunyung", "Mari", "Juwan" };
            foreach (string name in namesArr)
            {
                Console.WriteLine($"{name}");
            } */

            /* int start = 0;
            int end = 0;
            int total = 0;

            for (var i = start; i <= end; i++)
            {
                if (start < 1)
                {
                    System.Console.Write("Starts at: ");
                    start = Convert.ToInt32(Console.ReadLine());

                    if (end <= start)
                    {
                        System.Console.Write("Ends at: ");
                        end = Convert.ToInt32(Console.ReadLine());
                    }
                }
                total += i;
            }
            Console.WriteLine($"The sum from {start} through {end} is equal to {total}."); */


            /* for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            } */


            /* Console.Write("Please type your name: ");
            var name = Console.ReadLine();
            string providedName = (name == "Loug") ? name : "invalid name";

            Console.WriteLine("Hello, {0}", providedName);
            Console.WriteLine($"Hello, {providedName}"); */
        }
    }
}