using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Abstract_Factory
{
    // клиент - сам супергерой
    class Hero
    {
        private WeaponAbstract weapon;
        private MovementAbstarct movement;
        public Hero(HeroFactoryAbstract factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Run()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }
}
