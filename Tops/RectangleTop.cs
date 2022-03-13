using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTask2.Tops
{
    public class RectangleTop : TableTop
    {
        ChipBoard mainMaterial;
        double makingPrice;
        public Size Size => mainMaterial.Size;
        public override double Price => mainMaterial.Price + makingPrice;
        public RectangleTop(ChipBoard cb, double price)
        {
            mainMaterial = cb;
            makingPrice = price;
        }
    }
}
