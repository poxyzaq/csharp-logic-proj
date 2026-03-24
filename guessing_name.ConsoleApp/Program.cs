namespace guessing_name.ConsoleApp
{
    class Program
    {
        private static void Main()
        {
            Console.Clear();

            do
            {
                string menuChoice = ShowMenu();
                switch (menuChoice)
                {
                    case "q":
                        Environment.Exit(0);
                        break;

                    case "1":
                        RunGame();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Invalid option. Try again..");
                        break;
                }
            } while (true);
        }

        private static string ShowMenu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("GUESSING GAME");
            Console.WriteLine("----------------------");
            Console.WriteLine("(1) Start\n");
            Console.WriteLine("(q) Quit");
            Console.WriteLine("----------------------");
            Console.Write("> ");

            return (Console.ReadLine() ?? string.Empty).ToLower();
        }

        private static void RunGame()
        {
            int randomNumber = GetRandNum();

            do
            {
                // debug
                Console.WriteLine("----------------------------------");
                Console.WriteLine(randomNumber);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Guess the number im thinking!");
                Console.WriteLine("----------------------------------");
                Console.Write("Your guess > ");
                string strPlayerGuess = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("----------------------------------");
                Console.Clear();

                if (!int.TryParse(strPlayerGuess, out int intPlayerGuess))
                {
                    Console.WriteLine("Invalid number. Try again..");
                    continue;
                }

                Console.WriteLine($"You guessed the number {intPlayerGuess}..");
                Console.WriteLine("----------------------------------");
                Console.Write($"You");

                for (int dotC = 1; dotC <= 3; dotC++)
                {
                    Thread.Sleep(1);
                    Console.Write(".");
                }
                Console.Write(" ");

                if (intPlayerGuess == randomNumber)
                {
                    Console.WriteLine($"guessed right! The number was {randomNumber}");
                    break;
                }
                else if (intPlayerGuess < randomNumber)
                {
                    Console.WriteLine(
                        $"Good try! But the number is bigger than {intPlayerGuess}.."
                    );
                }
                else
                {
                    Console.WriteLine(
                        $"Good guess! but the number is smaller than {intPlayerGuess}"
                    );
                }
            } while (true);
        }

        private static int GetRandNum()
        {
            Random random = new();
            int randomNumber = random.Next(1, 20);

            return randomNumber;
        }
    }
}
