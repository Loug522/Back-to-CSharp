namespace ConsoleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please type your name: ");
            var name = Console.ReadLine();
            string providedName = name == "Loug" ? name : "invalid name";

            // Console.WriteLine("Hello, {0}", providedName);
            Console.WriteLine($"Hello, {providedName}");
        }
    }
}