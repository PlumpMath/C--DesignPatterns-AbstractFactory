using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Colors
{
    class Green : IColor
    {
        public void Colorize()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I am the color Green!");
        }
    }
}
