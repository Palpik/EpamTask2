using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealTask2.ChipBoards;
using RealTask2.Tops;

namespace RealTask2.Cutters
{
    class CircleCutter : Cutter
    {
        public CircleCutter(double price) : base(price)
        { }
        public CircleTop CircleCut(ChipBoard cb, double radius, out List<ChipBoard> remains)
        {
            ChipBoard tableMaterial = Cut(cb, new Size(radius,radius), out remains);
            return new CircleTop(tableMaterial, tableMaterial.Size.Perimeter * Price);
        }
    }
}
