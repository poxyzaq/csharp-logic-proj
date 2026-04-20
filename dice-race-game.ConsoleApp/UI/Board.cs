using dice_race_game.ConsoleApp.Entities;

namespace dice_race_game.ConsoleApp.UI
{
    public static class Board
    {
        private const int boardSize = 2;
        private const int pathSize = 30;

        public static char[,] board = 
            new char[boardSize, pathSize];
        public const char skin = '_';

        public static void Populate()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < pathSize; col++)
                {
                    board[row, col] = skin;
                }
            }

            board[Player.rowNumber, 0] = Player.skin;
            board[Cpu.rowNumber, 0] = Cpu.skin;
        }

        public static void Log()
        {
            Console.WriteLine($"(Player) {Player.prevPos} -> {Player.currPos}");
            Console.WriteLine($"(Cpu) {Cpu.prevPos} -> {Cpu.currPos}");
            Console.WriteLine("---");
            Console.WriteLine("==============================");
            Console.WriteLine("            Board             ");
            Console.WriteLine("==============================");

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < pathSize; col++)
                {
                    Console.Write($"{board[row, col]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("---");
            Console.Write("Press any key to continue..");
            Console.ReadLine();
            Console.Clear();
        }
    }
}


