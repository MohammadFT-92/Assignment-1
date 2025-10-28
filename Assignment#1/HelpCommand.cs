using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class HelpCommand : ICommand
    {
        public string Name => "help";

        public void Execute(CommandCenter1 center)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("help : Show availabe commands");
            Console.WriteLine("status : Check the current status");
            Console.WriteLine("set_name : Changeyour name");
            Console.WriteLine("calculator : a simple math");
            Console.WriteLine("game : Fun game");
            Console.WriteLine("exit : Exit the program");
        }

    }
}
