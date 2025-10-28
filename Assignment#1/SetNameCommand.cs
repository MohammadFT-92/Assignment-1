using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_1
{
    public class SetNameCommand : ICommand
    {
        public string Name => "setname";

        public void Execute(CommandCenter1 center )
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter Your New Name ");
            string newName = Console.ReadLine();
            center.SetUserName(newName);
            Console.WriteLine($"Updated name");
            Console.WriteLine(newName);
        }
    }
}
