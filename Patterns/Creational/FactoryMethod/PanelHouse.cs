using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.FactoryMethod
{
    class PanelHouse : HouseAbsctract
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
}
