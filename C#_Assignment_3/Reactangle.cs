using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_3
{
    public class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area => Length * Width; // Calculate the area of the rectangle

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area}");
        }
    }

}
