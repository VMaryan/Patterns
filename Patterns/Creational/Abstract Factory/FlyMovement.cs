using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Abstract_Factory
{
    // движение полета
    class FlyMovement : MovementAbstarct
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
