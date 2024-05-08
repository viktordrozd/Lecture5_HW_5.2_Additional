using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartII
{
    internal class Circle : Shape
    {
        protected double radius {  get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
