using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Functions
    {
        public static string GetStringCommand()
        {
            string input;
            while (true)
            {
                //Console.WriteLine("Enter Your input");
                input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
                {
                    return input;
                }
                Console.WriteLine(" Invalid Input, Please Input a String");
            }
        }
        public static void SimpleCalc()
        {
            Console.WriteLine("This is a calculator"); 
            
            bool running = true;
            while (running)
            {
                Console.WriteLine("Choose one please");
                Console.WriteLine("1 - add");
                Console.WriteLine("2 - sub");
                Console.WriteLine("3 - mul");
                Console.WriteLine("4 - div");
                Console.WriteLine("5 - quit");
                string opr = Console.ReadLine();
                Console.WriteLine("------------------------------------------");
                switch (opr.ToLower())
                {
                    case "1":
                    case ("add"):
                    case "2":
                    case ("sub"):
                    case "3":
                    case ("mul"):
                    case "4":
                    case ("div"):
                        Console.WriteLine(" Your First Number");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Your Second Number");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("------------------------------------------");
                        switch (opr)
                        {
                            case "1":
                            case ("add"):
                                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                                break;
                            case "2":
                            case ("sub"):
                                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                                break;
                            case "3":
                            case ("mul"):
                                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                                break;
                            case "4":
                            case ("div"):
                                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                                break;
                        }
                        break;

                    case "5":
                    case ("quit"):
                        Console.WriteLine("Thank you For using the calculator !");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("You have Five Options, Choose one");
                        Console.WriteLine(" (help,status,set name,game,calculator, exit) ");
                        running = false;

                        break;

                    default:
                        Console.WriteLine("invalid input");
                        Console.WriteLine("Enter valid operation");
                        break;
                }
            }
        }
        
    /*public static void AnotherOpr()
        {
            Console.WriteLine("Another Operation with same numbers");
            string opr = Console.ReadLine();
        }*/

    }
}
