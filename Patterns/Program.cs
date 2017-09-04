using System;
using Patterns.Creational.Abstract_Factory;
using Patterns.Creational.FactoryMethod;
using Patterns.Creational.Prototype;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational

            #region FactoryMethod
            Console.WriteLine("FactoryMethod:");
            DeveloperAbsract dev = new PanelDeveloper("ООО КирпичСтрой");
            HouseAbsctract house2 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            HouseAbsctract house = dev.Create();
            Console.WriteLine("");
            #endregion


            #region Abstract Factory
            Console.WriteLine("Abstract Factory:");

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Console.WriteLine("");
            #endregion

            #region Prototype
            Console.WriteLine("Prototype:");

            Console.WriteLine("1. Copy: ");
            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30, 10, 20);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.WriteLine("2. Copy 2: ");
            Circle clonedFigure2 = figure.Clone2() as Circle;
            clonedFigure2.Point.X = 50;
            clonedFigure2.Point.X = 60;
            figure.GetInfo();
            clonedFigure2.GetInfo();

            Console.WriteLine("3. DeepCopy: ");
            figure = new Circle(50, 100, 200);
            Circle clonedFigure3 = figure.DeepCopy() as Circle;
            clonedFigure2.Point.X = 10;
            clonedFigure2.Point.X = 10;
            figure.GetInfo();
            clonedFigure2.GetInfo();

            Console.WriteLine("");
            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
