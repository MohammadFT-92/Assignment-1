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

        public void Execute(CommandCenter1 center)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Current Status: {center.work}");
            Console.WriteLine($"Current user: {center.name}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Type help to return to the menu");
        }

       
    }
}
