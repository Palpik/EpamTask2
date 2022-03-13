using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTask2
{
    public abstract class Cutter
    {
        public double Price { get; protected set; }
        public Cutter(double price)
        {
            Price = price;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
        protected ChipBoard Cut(ChipBoard cb, Size size, out List<ChipBoard> remains)
        {
            if (cb.Size < size || (!(cb.Size > size) && cb.Size != size))
                throw new Exception("Не подходящий размер");
            remains = new List<ChipBoard>();
            if (cb.Size > size)
            {
                if (size.SideA < cb.Size.SideA)
                    remains.Add(cb.New(cb.Thickness, new Size(cb.Size.SideA - size.SideA, cb.Size.SideB)));
                if (size.SideB < cb.Size.SideB)
                    remains.Add(cb.New(cb.Thickness, new Size(size.SideA, cb.Size.SideB - size.SideB)));
            }
            return cb.New(cb.Thickness, size);
        }
    }
}
