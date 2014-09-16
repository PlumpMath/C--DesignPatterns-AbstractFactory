using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Interfaces;
using AbstractFactory.Shapes;
using AbstractFactory.Colors;

namespace AbstractFactory.Factories
{
    class ShapeFactory : IFactory
    {
        public IColor CreateColor(String color)
        {
            return null;
        }

        public IShape CreateShape(String shape)
        {
            shape = shape.ToLower();
            switch (shape)
            {
                case "rectangle":
                    return new Rectangle();
                case "square":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
