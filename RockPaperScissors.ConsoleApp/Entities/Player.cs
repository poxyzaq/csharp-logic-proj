namespace RockPaperScissors.ConsoleApp.Entities
{
    public static class Player
    {
        public static string GetChoice()
        {
            do 
            {
                string choice;
                Console.WriteLine("-------------------------");
                Console.Write("Enter your choice > ");
                choice = Console.ReadLine();
                Console.WriteLine("-------------------------");

                if (choice != "1" && 
                        choice != "2" &&
                        choice != "3")
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Invalid option. Try again..");
                    continue;
                }

                return choice;
            } while (true);
        }
    }
}
