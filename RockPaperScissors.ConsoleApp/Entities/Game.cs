using System.Runtime.Versioning;

namespace RockPaperScissors.ConsoleApp.Entities
{
    public static class Game
    {
        private const string RockChoice = "1";
        private const string PaperChoice = "2";
        private const string ScissorsChoice = "3";

        public static void CompareChoices
        (
            string playerChoice, string cpuChoice
        )
        {
            if (playerChoice == cpuChoice)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Draw");
            }
            else if (playerChoice == RockChoice)
            {
                Console.Write("Rock vs ");

                if (cpuChoice == PaperChoice)
                {
                    Console.WriteLine("Paper");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Cpu won");
                }
                else if (cpuChoice == ScissorsChoice)
                {
                    Console.WriteLine("Scissors");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Player won");
                }
            }
            else if (playerChoice == PaperChoice)
            {
                Console.WriteLine("Paper vs ");
                
                if (cpuChoice == RockChoice)
                {
                    Console.WriteLine("Rock");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Player won");
                }
                else if (cpuChoice == ScissorsChoice)
                {
                    Console.WriteLine("Scissors");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Cpu won");
                }
            }
            else if (playerChoice == ScissorsChoice)
            {
                Console.Write("Scissors vs ");

                if (cpuChoice == RockChoice)
                {
                    Console.WriteLine("Rock");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Cpu won");
                }
                else if (cpuChoice == PaperChoice)
                {
                    Console.WriteLine("Paper");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Player won");
                }
            }
        }
    }
}
