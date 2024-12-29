using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_3
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius; // Calculate the area of the circle

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        }
    }
}
