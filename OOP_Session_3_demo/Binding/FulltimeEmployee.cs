using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session_3_demo.Binding
{
    internal class FulltimeEmployee:Employee
    {

        public decimal Salary { get; set; }

        public FulltimeEmployee(int id,string name,int age,decimal salary):base(id,name,age) {
            Salary = salary;    
        
        }
        public override void Employee_Data()
        {
            Console.WriteLine($"Employee ID is : {Id} \n Employee Name is : {Name} \n Employee Age is :{Age} \n Salary is :{Salary}");
        }

        public new void EmployeeType()
        {
            Console.WriteLine("Iam FullTimeEmployee");
        }

    }
}
