using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class GameCommand :ICommand
    {
        public string Name => "game";

        public void Execute(CommandCenter center, string name)
        {
            Console.WriteLine("------------------------------------------");
            GuessGame.GuesGame();
            Console.WriteLine("You have return to the First menu");
            Console.WriteLine(" (help,status,set name,game,calculator, exit) ");
        }

        public void Execute(CommandCenter1 commandCenter1)
        {
            throw new NotImplementedException();
        }
    }
}
