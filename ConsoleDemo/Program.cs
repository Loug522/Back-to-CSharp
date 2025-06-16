namespace ConsoleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            /* Console.Write("Please type your name: ");
            var name = Console.ReadLine();
            string providedName = (name == "Loug") ? name : "invalid name";

            Console.WriteLine("Hello, {0}", providedName);
            Console.WriteLine($"Hello, {providedName}"); */
        }
    }
}