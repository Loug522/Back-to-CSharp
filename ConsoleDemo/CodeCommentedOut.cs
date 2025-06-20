namespace ConsoleDemo
{
    class CodeCommentedOut
    {
        /* string myStr = "Neun Welten";
            char[] charArr = myStr.ToCharArray();
            Array.Reverse(charArr);
            foreach (char charItem in charArr)
            {
                Console.Write($"{charItem}");
            } */


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


        /* Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        DisplayResult(firstName, lastName, city);

        DisplayResult("Hello, World!"); */

        // <<<------------------------------>>>
        
        /* private static string ToReversedString(string message)
        {
            char[] messageChar = message.ToCharArray();
            Array.Reverse(messageChar);
            return String.Concat(messageChar);
        }

        private static void DisplayResult(string revFName, string revLName, string revCity)
        {
            Console.WriteLine($"Results:");
            Console.WriteLine($"{ToReversedString(revFName)} {ToReversedString(revLName)} {ToReversedString(revCity)}");
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"Results: \n{ToReversedString(message)}");
                        
        } */
    }
}