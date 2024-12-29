using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Session_3_demo.Interfaces;

namespace OOP_Session_3_demo.Binding
{
    internal class Dog:IAnimal
    {
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("IAm dog");
        }
   

    }
}
