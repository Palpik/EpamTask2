using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTask2
{
    public struct Size
    {
        public double SideA { get; }
        public double SideB { get; }
        public Size(double length, double width)
        {
            SideA = length;
            SideB = width;
        }
        public double Perimeter => SideA + SideB;
        public static bool operator ==(Size s1, Size s2)
        {
            return (s1.SideA == s2.SideA && s1.SideB == s2.SideB) || (s1.SideA == s2.SideB && s1.SideB == s2.SideA);
        }
        public static bool operator !=(Size s1, Size s2)
        {
            return !((s1.SideA == s2.SideA && s1.SideB == s2.SideB) || (s1.SideA == s2.SideB && s1.SideB == s2.SideA));
        }
        public static bool operator <(Size s1, Size s2)
        {
            return (s1.SideA < s2.SideA && s1.SideB <= s2.SideB) || (s1.SideB < s2.SideB && s1.SideA <= s2.SideA)
                || (s1.SideB < s2.SideA && s1.SideA <= s2.SideB) || (s1.SideA < s2.SideB && s1.SideB <= s1.SideA);
        }
        public static bool operator >(Size s1, Size s2)
        {
            return (s1.SideA > s2.SideA && s1.SideB >= s2.SideB) || (s1.SideB > s2.SideB && s1.SideA >= s2.SideA)
                || (s1.SideB > s2.SideA && s1.SideA >= s2.SideB) || (s1.SideA > s2.SideB && s1.SideB >= s1.SideA);
        }
        public static bool operator <=(Size s1, Size s2)
        {
            return s1 == s2 || s1 < s2;
        }
        public static bool operator >=(Size s1, Size s2)
        {
            return s1 == s2 || s1 > s2;
        }
        public double Square()
        {
            return SideA * SideB;
        }
        public override int GetHashCode()
        {
            return (SideA + SideB).GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Size size)
                return size == this;
            return false;
        }
    }
}
