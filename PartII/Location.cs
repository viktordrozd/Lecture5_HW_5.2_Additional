using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartII
{
    internal class Location
    {
        protected double x { get; set; }
        protected double y { get; set; }

        public Location(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX() { return x; }
        public double getY() { return y; }
    }
}
