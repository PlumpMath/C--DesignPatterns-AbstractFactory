using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Interfaces
{
    interface IShape
    {
        // define abstract factory method that concrete factories will implement
        void Draw();
    }
}
