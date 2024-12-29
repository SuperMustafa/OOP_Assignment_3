using OOP_Session_3_demo.Binding;
using OOP_Session_3_demo.Interfaces;

namespace OOP_Session_3_demo
{
    internal class Program
    {
        static void printInfo(Employee emp)
        {
            if (emp is not null)
            {
                emp.Employee_Data();
                emp.EmployeeType();

            }
        }

            

                static void Main(string[] args)
                {

            #region Binding [static Binding(early binding) // dynamic binding(late binding)]
            #region Example 1
            // statcic binding is bind call method based on refernce type using key word new
            //ref from parent point to object from child
            //Type_A ref_Base = new Type_B(2,3);
            //ref_Base.print_1();
            //=========================================================
            // dynamic binding is bind method call based on object type using key word override
            //ref_Base.print_2();
            //Type_B B = new Type_B(55, 5);
            //B.print_1();
            //B.print_2();
            #endregion


            #region Example 2
            //FulltimeEmployee FullEmp = new FulltimeEmployee(01, "Mustafa", 27, 20000);

            //ParttimeEmployee emp = new ParttimeEmployee()
            //{
            //    Id = 01,
            //    Name = "Mustafa",
            //    Age = 27,
            //    HourRate = 22,
            //    CountOfHours = 33,

            //};
            //printInfo(FullEmp);
            //Console.WriteLine("=======================================");
            //printInfo(emp);

            #endregion


            #endregion
            #region Interface
            //is a contract that defines a set of methods, properties, events, or indexers without implementing them.
            //A class or struct that implements an interface agrees to implement all its members.
            //Interfaces are used to define a common functionality that multiple classes can implement in their own way.



            //we can not make an object from interface
            // but we can create a refernce from interface and point to a class or struct that implement that interface
            // default implemented method at interface we cannot access it , only way that we create a ref from interface 
            //and point to class and call it throw that object we had create
            IAnimal jac = new Dog();
            jac.Print();
            jac.Same();
            #endregion

        }
    }
        }
    
