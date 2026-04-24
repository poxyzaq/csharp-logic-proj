namespace dice_race_game.ConsoleApp.UI
{
    public class Menu
    {
        public static char Option()
        {
                Console.Clear();
                Console.WriteLine("---");
                Console.WriteLine("==============================");
                Console.WriteLine("Dice racing game (v3.14159265)");
                Console.WriteLine("==============================");
                Console.WriteLine("(1) Start\n");
                Console.WriteLine("(q) Quit");
                Console.WriteLine("==============================");
                Console.WriteLine("---");
                Console.Write("> ");
                char test = Convert.ToChar(Console.ReadLine().ToUpper());

                return test;
        }
    }
}
