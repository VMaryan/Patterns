using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Abstract_Factory
{
    // Фабрика создания бегущего героя с мечом
    class VoinFactory : HeroFactoryAbstract
    {
        public override MovementAbstarct CreateMovement()
        {
            return new RunMovement();
        }

        public override WeaponAbstract CreateWeapon()
        {
            return new Sword();
        }
    }
}
