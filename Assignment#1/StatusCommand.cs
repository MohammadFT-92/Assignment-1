using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_1
{
    public class StatusCommand : ICommand
    {
        public string Name => "status";

        public void Execute(CommandCenter center, string name, string work)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Current Status: {work}");
            Console.WriteLine($"Current user: {name}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Type help to return to the menu");
        }

    }
}
