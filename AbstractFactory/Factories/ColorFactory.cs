using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Interfaces;
using AbstractFactory.Shapes;
using AbstractFactory.Colors;

namespace AbstractFactory.Factories
{
    class ColorFactory : IFactory
    {
        public IColor CreateColor(String color)
        {
            color = color.ToLower();
            switch (color)
            {
                case "green":
                    return new Green();
                case "red":
                    return new Red();
                default:
                    return null;
            }
        }

        public IShape CreateShape(String shape)
        {
            return null;
        }
    }
}
