namespace RockPaperScissors.ConsoleApp.Screens
{
    public static class PlayerScreen
    {

        public static void DisplayHeader()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Rock Paper Scissors");
            Console.WriteLine("-------------------------");
        }

        public static void DisplayChoices()
        {
            DisplayHeader();
            Console.WriteLine("(1) Rock");
            Console.WriteLine("(2) Paper");
            Console.WriteLine("(3) Scissors");
        }

        public static bool playAgain()
        {
            do
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Play again? (y/n)");
                Console.Write("> ");
                string decision = Console.ReadLine();

                if (decision == "y")
                {
                    return true;
                }
                else if (decision == "n")
                {
                   return false; 
                }

                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("Invalid option. Try again..");
            } while (true);
        }
    }
}
