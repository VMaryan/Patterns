using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.FactoryMethod
{
    // абстрактный класс строительной компании
    public abstract class DeveloperAbsract
    {
        public string Name { get; set; }

        public DeveloperAbsract(string n)
        {
            Name = n;
        }

        // фабричный метод
        abstract public HouseAbsctract Create();
    }
}
