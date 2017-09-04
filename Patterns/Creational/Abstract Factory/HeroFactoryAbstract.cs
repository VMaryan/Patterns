using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Abstract_Factory
{
    // класс абстрактной фабрики
    public abstract class HeroFactoryAbstract
    {
        public abstract MovementAbstarct CreateMovement();
        public abstract WeaponAbstract CreateWeapon();
    }
}
