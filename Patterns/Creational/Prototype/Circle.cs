using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Prototype
{
    [Serializable]
    class Circle : IFigure
    {
        int radius;

        public Point Point { get; set; }

        public Circle(int r, int x, int y)
        {
            radius = r;
            this.Point = new Point { X = x, Y = y };
        }

        public IFigure Clone()
        {
            return new Circle(this.radius, Point.X, Point.Y);
        }

        // Mетод MemberwiseClone() осуществляет неполное копирование - то есть копирование значимых типов.
        // Если же класс фигуры содержал бы объекты ссылочных типов, то оба объекта после клонирования содержали бы ссылку на один и тот же ссылочный объект.
        public IFigure Clone2()
        {
            return this.MemberwiseClone() as IFigure;
        }

        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binFormatter.Deserialize(tempStream);
            }
            return figure;
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", radius, Point.X, Point.Y);
        }
    }
}
