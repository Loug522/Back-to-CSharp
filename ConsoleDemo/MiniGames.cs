namespace ConsoleDemo
{
    class MiniGames
    {
        public static void DisplayMenu()
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = Menu();
            }           
        }

        public static void ReturnToMenu()
        {
            Console.WriteLine($"\nPress ENTER to go back to the MENU.");
            Console.ReadLine();
        }

        public static bool Menu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Guess the number");
            Console.WriteLine("2) Guess the character");
            Console.WriteLine("3) EXIT");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                NumberGuessing();
                return true;
            }
            else if (userInput == 2)
            {
                CharacterGuessing();
                return true;
            }
            else
            {
                Console.WriteLine($"EXITED!");
                return false;
            }
        }


        // NUMBER GUESSING GAME
        private static void NumberGuessing()
        {
            Random myRandom = new Random();
            int rNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine($"Guess the number between 1 and 10");
                int userInput = int.Parse(Console.ReadLine());
                guesses++;

                if (userInput != rNumber)
                {
                    Console.WriteLine($"Wrong! Try Again!");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The number was {rNumber}! It took {guesses} guesses.");
                    incorrect = false;
                }
            } while (incorrect);
            ReturnToMenu();
        }


        // CHARACTER GUESSING GAME
        private static void CharacterGuessing()
        {
            Console.WriteLine($"Character guessing game!");
            ReturnToMenu();
        }
    }
}
