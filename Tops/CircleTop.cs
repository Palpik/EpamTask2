using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTask2.Tops
{
    class CircleTop : TableTop
    {
        ChipBoard mainMaterial;
        double makingPrice;
        public override double Price => mainMaterial.Price + makingPrice;
        public double Radius { get; }
        public CircleTop(ChipBoard cb, double price)
        {
            if (cb.Size.SideA != cb.Size.SideB)
                throw new Exception("Столешница не круглая");
            mainMaterial = cb;
            makingPrice = price;
        }
    }
}
