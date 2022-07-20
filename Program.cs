using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2b
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Fahrenheit and Celsius Converter in C# by Tobias Lenander";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            Menu objConverter = new(); //This creates an object of the menu class
            objConverter.Start(); //This starts the menu start method
        }
    }
}