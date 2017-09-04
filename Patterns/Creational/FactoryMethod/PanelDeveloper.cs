using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.FactoryMethod
{
    // строит панельные дома
    class PanelDeveloper : DeveloperAbsract
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override HouseAbsctract Create()
        {
            return new PanelHouse();
        }
    }
}
