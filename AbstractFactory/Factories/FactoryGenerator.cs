using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    class FactoryGenerator
    {
        public static IFactory GenerateFactory(String factoryType)
        {
            factoryType = factoryType.ToLower();
            switch (factoryType)
            {
                case "shape":
                    return new ShapeFactory();
                case "color":
                    return new ColorFactory();
                default:
                    return null;
            }
        }
    }
}
