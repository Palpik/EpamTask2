using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTask2
{
    public abstract class ChipBoard
    {
        public double Thickness { get; }
        public Size Size { get; }
        public abstract double Price { get; }
        public ChipBoard(double thikness, Size size)
        {
            Size = size;
            Thickness = thikness;
        }
        public ChipBoard(double thickness, double length, double width)
        {
            Size = new Size(length, width);
            Thickness = thickness;
        }
        public abstract ChipBoard New(double thickness, Size size);
        public override bool Equals(object obj)
        {
            if (obj is ChipBoard cb)
                return cb.Thickness == Thickness && cb.Size == Size && cb.Price == Price;
            return false;
        }
        public override int GetHashCode()
        {
            return (Thickness * Size.SideA * Size.SideB).GetHashCode();
        }
    }
}
