using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Polymorphism
    {
        static void Main()
        {
            employee[] employees = new employee[] { new employee(), new partTimeEmp(), new FullTimeEmp(), new tempEmp() };
            
            foreach(employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }

    public class employee
    {
        public string Fname = "FN";
        public string Lname = "LN";

        /// <summary>
        /// 1. the reason we are making this method virtual is because it tells its derived class (child classes) that they can override this method
        /// </summary>
        public virtual void PrintFullName()
        {
            Console.WriteLine(Fname + " " + Lname);
        }
    }

    public class partTimeEmp : employee
    {   /// <summary>
        /// 2. because we made the parent a virtual class, if we want to override it or print something spicifically for this one class, we use the
        /// override word
        /// </summary>
        public override void PrintFullName()
        {
            Console.WriteLine(Fname + " " + Lname + " - Part Time");
        }
    }

    public class FullTimeEmp : employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(Fname + " " + Lname + " - Full Time");
        }
    }
    public class tempEmp : employee
    {/// <summary>
    /// 3. if we were to remove the PrintFullName method here then the program would revert back to its "default" which is the base class method
    /// </summary>
        public override void PrintFullName()
        {
                Console.WriteLine(Fname + " " + Lname + " - Temp");
        }
    }
}
