using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Colors
{
    class Red : IColor
    {
        public void Colorize()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I am the color Red!");
        }
    }
}
