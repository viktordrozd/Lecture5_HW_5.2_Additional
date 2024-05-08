using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartII
{
    abstract class Shape
    {
        protected Location? location { get; private protected set; }

        internal void SetLocation(double x, double y)
        {
            this.location = new Location(x, y);
        }


        public override string ToString()
        {
            var res = "";
            res += "X coordinate: " + this.location.getX().ToString() + "\n";
            res += "Y coordinate: " + this.location.getY().ToString() + "\n";

            return res;
        }

        public abstract double Area();


        public abstract double Perimeter();
    }
}
