using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_3
{
    public interface IShape
    {
        double Area { get; }     // Property to get the area of the shape
        void DisplayShapeInfo(); // Method to display shape information
    }

}
