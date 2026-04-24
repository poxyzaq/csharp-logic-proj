using dice_race_game.ConsoleApp.UI;
using dice_race_game.ConsoleApp.Core;

namespace dice_race_game.ConsoleApp
{
    public class Program
    {
        private static void Main()
        {
            do
            {
                Console.Clear();

                char option = Menu.Option();

                if (option == 'q')
                {
                    Environment.Exit(1);
                }

                if (option == '1')
                {
                    Game.Start();
                }

            } while (true);
        }
    }
}
