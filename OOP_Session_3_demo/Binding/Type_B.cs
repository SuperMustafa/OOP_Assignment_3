using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session_3_demo.Binding
{
    internal class Type_B:Type_A
    {
        public int B { set; get; }  // this is property

        public Type_B(int _A, int _B) : base(_A)
        {
            B = _B;
        }

        public new void print_1()
        {
            Console.WriteLine("iam child");

        }
        public  void print_2()
        {
            Console.WriteLine($"type A is :{A} and Type B is : {B}");

        }

    }
}
