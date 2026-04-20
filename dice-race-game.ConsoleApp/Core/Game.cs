using dice_race_game.ConsoleApp.UI;
using dice_race_game.ConsoleApp.Entities;

namespace dice_race_game.ConsoleApp.Core
{
    public class Game
    {
        public static void Start()
        {
            Console.Clear();
            Board.Populate();
            Board.Log();

            do
            {
                if (Player.isTurn) 
                {
                    Player.RollDice();
                    Player.MoveDice();
                    Player.WatchForEvent();
                    if (Player.CheckIfWon())
                    {
                        Board.Log();
                        break;
                    };
                    Player.UpdatePosition();
                    Board.Log();

                }
                else 
                {

                    Cpu.RollDice();
                    Cpu.MoveDice();
                    Cpu.WatchForEvent();
                    if (Cpu.CheckIfWon())
                    {
                        Board.Log();
                        break;
                    }
                    Cpu.UpdatePosition();
                    Board.Log();
                }

            } while (true);

            Player.prevPos = 0;
            Player.currPos = 0;
            Cpu.prevPos = 0;
            Cpu.currPos = 0;
        }
    }
}





