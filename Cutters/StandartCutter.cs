using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealTask2.Tops;
using RealTask2.ChipBoards;

namespace RealTask2.Cutters
{
    public class StandartCutter : Cutter
    {
        public StandartCutter(double price) : base(price)
        { }
        public RectangleTop CutRectangleTop(ChipBoard cb, Size size, out List<ChipBoard> remains)
        {
            ChipBoard tableMaterial = Cut(cb, size, out remains);
            return new RectangleTop(tableMaterial, tableMaterial.Size.Perimeter * Price);
        }
    }

}
