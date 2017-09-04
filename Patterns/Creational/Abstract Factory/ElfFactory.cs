using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Abstract_Factory
{
    // Фабрика создания летящего героя с арбалетом
    class ElfFactory : HeroFactoryAbstract
    {
        public override MovementAbstarct CreateMovement()
        {
            return new FlyMovement();
        }

        public override WeaponAbstract CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
