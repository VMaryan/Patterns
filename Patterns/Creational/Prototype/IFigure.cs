using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Prototype
{
    interface IFigure
    {
        IFigure Clone();

        IFigure Clone2();

        object DeepCopy();

        void GetInfo();
    }
}
