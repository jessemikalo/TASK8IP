using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK8IP
{
    internal class Circle
    {
        //Constructor:
        public Circle(double radius)
        {
            Radius = radius;
        }

        //Properties: starting with upper case letter!
        public double Radius { get; set; }

        //Instance methods:
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            //return base.ToString();
            return "Radius is " + String.Format("{0:F2}", Radius);
        }

    }
}
