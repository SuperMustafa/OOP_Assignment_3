using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session_3_demo.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }



        

        public Employee(int id ,string name, int age) 
        {
            Id = id;
            Name = name;
            Age = age;
        
        }
        public Employee() { }

    public virtual void Employee_Data()
        {
            Console.WriteLine($"Employee ID is : {Id} \n Employee Name is : {Name} \n Employee Age is :{Age} ");
        }

        public void EmployeeType()
        {
            Console.WriteLine("Iam Employee");
        }
    }
}

