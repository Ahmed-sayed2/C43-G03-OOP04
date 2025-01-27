using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.First_Project
{
    internal class A3DPoint:ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public A3DPoint(int x, int y, int z)
        {
            X= x;
            Y= y;
            Z= z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        

       public object Clone()
        {
           return new A3DPoint(X, Y, Z);
        }
    }
}
