using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session_3_demo.Interfaces
{
    internal interface IAnimal
    {
         string Name { get; set; }

        void Print();
        void Same()
        {
            Console.WriteLine("Hello world");
        }
    }
}
