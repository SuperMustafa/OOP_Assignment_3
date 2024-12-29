using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session_3_demo.Binding
{
    internal class ParttimeEmployee:Employee
    {
        public int CountOfHours { get; set; }
        public int HourRate {  get; set; }

        
        public override void Employee_Data()
        {
            Console.WriteLine($"Employee ID is : {Id} \n Employee Name is : {Name} \n Employee Age is :{Age} \n Count of hours is :{CountOfHours} \n Hour rate is {HourRate} ");
        }

        public new void EmployeeType()
        {
            Console.WriteLine("Iam Part time employee");
        }
    }
}
