using System.Security.Cryptography;

namespace RockPaperScissors.ConsoleApp.Entities
{   
    public static class Cpu
    {
        public static string GetChoice()
        {
            return Convert.ToString(RandomNumberGenerator.GetInt32(1, 4));
        }
    }
}
