using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Interfaces
{
    interface IFactory
    {
        IColor CreateColor(String color);
        IShape CreateShape(String shape);
    }
}
