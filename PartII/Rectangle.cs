using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartII
{
    internal class Rectangle : Shape
    {
        protected double side1 { get; set; }
        protected double side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return side1 * 2 + side2 * 2;
        }
    }
}
