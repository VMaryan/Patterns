using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.FactoryMethod
{
    // строит деревянные дома
    class WoodDeveloper : DeveloperAbsract
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override HouseAbsctract Create()
        {
            return new WoodHouse();
        }
    }
}
