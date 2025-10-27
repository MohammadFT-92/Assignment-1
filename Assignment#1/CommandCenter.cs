using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class CommandCenter
    {
        public string name;
        public string work;

        public void Run()
        {
            Console.WriteLine("My name is mohammad al tabtabaee");
            Console.WriteLine("This is Assignment #1");


            // Funcions file was created and is public to connect both files
            // a Function under this comment used to get a string from the user
            // if the input is not a string, the user will have to input again
            Console.WriteLine("Enter Your name");
            string name = Functions.GetStringCommand();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter your work");
            string work = Functions.GetStringCommand();
            Console.WriteLine("------------------------------------");

            //string command = string.Empty;

            Console.WriteLine($"Welcome {name} the Trinee Command Center! ");
            Console.WriteLine("You have Five Options, Choose one");
            Console.WriteLine(" (help,status,set name,game,calculator, exit) ");

            string command = "";
            while (command != "exit")
            {
                command = Functions.GetStringCommand();
                HandleCommand(command);
            }
        }

        private void HandleCommand(string command)
        {
            switch (command)
            {
                case ("help"):
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("help : Show availabe commands");
                    Console.WriteLine("status : Check the current status");
                    Console.WriteLine("set_name : Changeyour name");
                    Console.WriteLine("calculator : a simple math");
                    Console.WriteLine("game : Fun game");
                    Console.WriteLine("exit : Exit the program");
                    break;

                case ("status"):
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Current Status: {work}");
                    Console.WriteLine($"Current user: {name}");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Type help to return to the menu");
                    break;

                case ("setname"):
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Enter Your New Name ");
                    name = Functions.GetStringCommand();
                    Console.WriteLine($"Updated name");
                    Console.WriteLine(name);
                    break;

                case ("exit"):
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Goodbye !");
                    break;

                case ("calculator"):
                    Console.WriteLine("------------------------------------------");
                    Functions.SimpleCalc();
                    break;

                case ("game"):
                    Console.WriteLine("------------------------------------------");
                    GuessGame.GuesGame();
                    Console.WriteLine("You have return to the First menu");
                    Console.WriteLine(" (help,status,set name,game,calculator, exit) ");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("input correct string");
                    break;

            }
        }
    }
}
