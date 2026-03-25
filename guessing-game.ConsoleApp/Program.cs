namespace guessing_name.ConsoleApp
{
    class Program
    {
        private static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Guessing game");
                Console.WriteLine("-------------------------------------");
                Console.Write("Enter you guess > ");

                int randomNum = RandomNumberGenerator.GetInt32(1, 21);
                // debug
                //Console.WriteLine(randomNum);
                int playerGuess = Convert.ToInt32(Console.ReadLine());

                if (playerGuess == randomNum)
                {
                    Console.WriteLine($"You got it! the number was {randomNum}");
                    break;
                }
                else if (playerGuess > randomNum)
                {
                    Console.WriteLine($"Nice try! but the number is smaller than {playerGuess}");
                }
                else
                {
                    Console.WriteLine($"Nice try! but the number is bigger than {playerGuess}");
                }
            } while (true);

            Console.WriteLine("Press Return to continue..");
            // while keypress is not enter, continue asking
            // true argument hides the pressed key on the screen
            // empty scope because when condition not true just run
            // again without doing anything else
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
