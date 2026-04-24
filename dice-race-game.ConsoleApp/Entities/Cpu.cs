using System.Security.Cryptography;
using dice_race_game.ConsoleApp.UI;

namespace dice_race_game.ConsoleApp.Entities
{
    public class Cpu
    {
        // atributes
        private static int[] extraMoveSquares = [5, 10, 15];
        private const int extraMove = 3;
        private static int[] moveBackSquares = [7, 13, 20];
        private const int moveBack = 2;
        private const int extraRoundRoll = 6;
        private static int roll = 0;

        public static bool isCpuTurn = false;
        public const char skin = '+';
        public static int rowNumber = 1;
        public static int prevPos = 0;
        public static int currPos = 0;

        // methods
        public static void RollDice()
        {
            Console.WriteLine("---");
            Console.WriteLine("Cpu turn!");
            Console.Write("Press any key to roll the dice..");
            Console.ReadLine();
            Console.WriteLine("---");
            Console.Write("Rolling");

            //for (int i = 0; i < 5; i++)
            //{
            //    Thread.Sleep(400);
            //    Console.Write(".");
            //}

            roll = RandomNumberGenerator.GetInt32(1, 7);
            Console.WriteLine($"\nCpu rolled {roll}!");
            Console.WriteLine("---");
        }

        public static void MoveDice()
        {
            prevPos = currPos;
            currPos += roll;
        }

        public static void WatchForEvent()
        {
                if (extraMoveSquares.Contains(currPos))
                {
                    Console.WriteLine($"Cpu hit square {currPos}. Stepping {extraMove}");
                    currPos += extraMove;
                }

                if (moveBackSquares.Contains(currPos))
                {
                    Console.WriteLine($"Cpu hit square {currPos}. Backing {moveBack}");
                    currPos -= moveBack;
                }

                if (roll == extraRoundRoll)
                {
                    Console.WriteLine($"Cpu rolled {extraRoundRoll}. Running extra round!");
                }
                else
                {
                    Player.isTurn = !Player.isTurn;
                }

            Console.WriteLine("---");
        }

        public static bool CheckIfWon()
        {
            if (currPos >= 30)
            {
                Console.WriteLine("Cpu won!");
                return true;
            }

            return false;
        }

        public static void UpdatePosition()
        {
            Board.board[rowNumber, prevPos] = Board.skin;
            Board.board[rowNumber, currPos] = skin;
        }
    }
}
