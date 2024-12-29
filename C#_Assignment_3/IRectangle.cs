using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_3
{
    public interface IRectangle : IShape
    {
        double Length { get; set; } // Property to define the length of the rectangle
        double Width { get; set; }  // Property to define the width of the rectangle
    }
}
