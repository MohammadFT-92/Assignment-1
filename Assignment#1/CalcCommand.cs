using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class CalcCommand : ICommand
    {
        public string Name => "calculator";

        public void Execute(CommandCenter1 center)
        {
            Console.WriteLine("------------------------------------------");
            Functions.SimpleCalc();
        }
    }
}
