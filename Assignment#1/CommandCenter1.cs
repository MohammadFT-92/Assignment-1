using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class CommandCenter1
    {
        public string name;
        public string work;

        public bool IsOperational { get; set; }
        public Dictionary<string, ICommand> commands;

        public CommandCenter1()
        {
            Console.WriteLine("Enter Your name");
            name = Functions.GetStringCommand();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter your work");
            work = Functions.GetStringCommand();
            Console.WriteLine("------------------------------------");

            

            IsOperational = true;
            commands = new Dictionary<string, ICommand>()
            {
                { "help", new HelpCommand() },
                { "status", new StatusCommand() },
                { "game", new GameCommand() },
                { "calculator", new CalcCommand() },
                { "setname", new SetNameCommand() }
            };
        }

        public void SetUserName (string NewName)
        { 
            name = NewName;
            Console.WriteLine($"Your Updated name is : {name}");
        }

        public void Run1()
        {
            Console.WriteLine($"Welcome {name} the Trinee Command Center! ");
            Console.WriteLine("You have Five Options, Choose one");
            Console.WriteLine(" (help,status,set name,game,calculator, exit) ");

            while (IsOperational)
            {
                Console.WriteLine("Type your Command :  ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "exit")
                {
                    IsOperational = false;
                    Console.WriteLine("Thank You For trying this Program");
                    Console.WriteLine("GoodBye");
                }

                if (commands.TryGetValue(input, out ICommand command))
                {
                    command.Execute(this);
                }
                else
                {
                    Console.WriteLine("You have entered Unknown Command");
                    Console.WriteLine("Type : help");
                }
            }
        }
    }
}
