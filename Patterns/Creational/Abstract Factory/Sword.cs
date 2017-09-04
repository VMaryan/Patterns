using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Abstract_Factory
{
    // класс меч
    class Sword : WeaponAbstract
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
