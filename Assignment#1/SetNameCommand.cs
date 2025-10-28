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

        public void Execute(CommandCenter center, string name)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter Your New Name ");
            name = Functions.GetStringCommand();
            Console.WriteLine($"Updated name");
            Console.WriteLine(name);
        }

        public void Execute(CommandCenter1 commandCenter1)
        {
            throw new NotImplementedException();
        }
    }
}
