using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Abstract_Factory
{
    class RunMovement : MovementAbstarct
    {
        // движение - бег
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
