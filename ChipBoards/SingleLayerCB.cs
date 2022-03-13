using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTask2.ChipBoards
{
   public class SingleLayerCB : ChipBoard
    {
        private double _priceModifier = 1.8;
        public double PriceModifier => _priceModifier;
        public override double Price
        {
            get
            {
                return Thickness * Size.Square() * PriceModifier;
            }
        }
        public override ChipBoard New(double thickness, Size size)
        {
            return new SingleLayerCB(thickness, size);
        }
        public SingleLayerCB(double thikness, double length, double width) : base(thikness,length,width)
        { }
        public SingleLayerCB(double thikness, Size size) : base(thikness, size)
        { }
    }
}
