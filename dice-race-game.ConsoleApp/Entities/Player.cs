using System.Security.Cryptography;
using dice_race_game.ConsoleApp.UI;

namespace dice_race_game.ConsoleApp.Entities
{
    public class Player
    {
        // atributes
        private readonly static int[] extraMoveSquares = [5, 10, 15];
        private const int extraMove = 3;
        private readstatic int[] moveBackSquares = [7, 13, 20];
        private const int moveBack = 2;
        private const int extraRoundRoll = 6;
        private static int roll = 0;

        public static bool isTurn = true;
        public const char skin = '*';
        public static int rowNumber = 0;
        public static int prevPos = 0;
        public static int currPos = 0;

        public static void RollDice()
        {
            Console.WriteLine("---");
            Console.WriteLine("Player turn!");
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
            Console.WriteLine($"\nPlayer rolled {roll}!");
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
                Console.WriteLine($"Player hit square {currPos}. Stepping {extraMove}");
                currPos += extraMove;
            }

            if (moveBackSquares.Contains(currPos))
            {
                Console.WriteLine($"Player hit square {currPos}. Backing {moveBack}");
                currPos -= moveBack;
            }

            if (roll == extraRoundRoll)
            {
                Console.WriteLine($"Player rolled {extraRoundRoll}. Running extra round!");
            }
            else
            {
                isTurn = !isTurn;
            }

            Console.WriteLine("---");
        }

        public static bool CheckIfWon()
        {
            if (currPos >= 30)
            {
                Console.WriteLine("Player won!");
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
