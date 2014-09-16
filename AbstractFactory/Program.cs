/* Author: Ryan Rasti
 * Purpose: To better understand the Abstract Factory design pattern
 * Acknowledgement: Thanks to tutorialspoint.com and C# 3.0 Design Patterns by Judith Bishop (c) 2008 for information on this design pattern
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Interfaces;
using AbstractFactory.Factories;
using AbstractFactory.Shapes;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Begin demonstration of Abstract Factory design pattern */
            /* Note that Program.cs (driver class) has no knowledge of the interfaces/factories involved*/
            /* It creates concrete factories and shapes/colors from the interfaces, as opposed to their concrete classes*/

            // create a shape factory using factory generator
            IFactory shapeFactory = FactoryGenerator.GenerateFactory("shape");

            // create a color factory using the factory generator
            IFactory colorFactory = FactoryGenerator.GenerateFactory("color");

            // create shapes from the abstract IFactory
            IShape rectangle = shapeFactory.CreateShape("rectangle");
            IShape square = shapeFactory.CreateShape("square");

            // create colors from the abstract IFactory
            IColor green = colorFactory.CreateColor("green");
            IColor red = colorFactory.CreateColor("red");

            // verify that the abstract colors and shapes display the correct output
            green.Colorize();

            rectangle.Draw();

            red.Colorize();

            square.Draw();

            // view console output of the program
            Console.Read();
        }
    }
}
