namespace RockPaperScissors.ConsoleApp;

using RockPaperScissors.ConsoleApp.Entities;
using RockPaperScissors.ConsoleApp.Screens;

public static class Program
{
    private static void Main()
    {
        do
        {
            Console.Clear();
            PlayerScreen.DisplayChoices();
            string playerChoice = Player.GetChoice();
            string cpuChoice = Cpu.GetChoice();
            Game.CompareChoices(playerChoice, cpuChoice);
        } while (PlayerScreen.playAgain());
    }
}
