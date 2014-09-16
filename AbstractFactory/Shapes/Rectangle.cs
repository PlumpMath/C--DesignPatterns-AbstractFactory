using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Shapes
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-                     -");
            Console.WriteLine("-                     -");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\n\n");
        }
    }
}
