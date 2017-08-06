using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodHiding
{
    class methodHiding
    {
        static void Main()
        {
            fullTimeEmp FTE = new fullTimeEmp();
            FTE.Fname = "Full";
            FTE.Lname = "Time";
            FTE.PrintFullName();

            partTimeEmp PTE = new partTimeEmp();
            PTE.Fname = "Part";
            PTE.Lname = "Time";
            PTE.PrintFullName();

            ((employee)PTE).PrintFullName(); //3.this is another way of doing 2 but here we are casting PTE as employee class rather than
                                             //partTimeEmp class (run it and see the difference)

            //4.another way of doing 2 but here we are saying that we have a new partTimeEmp that will reference the parent class. PTE1 is now
            //referencing a parent class rather than referencing a child class that in turn references a parent class. If, however, you 
            //switched employee and partTimeEmp, then it would not work because we are essentially making the partTimeEmp the base class and 
            //that is not how we set it up below.  
            //read it as: parent PTE1 = new Child. Doing Child PTE1 = new Parent does not work.
            employee PTE1 = new partTimeEmp(); 
            PTE1.Fname = "Part";
            PTE1.Lname = "Time";
            PTE1.PrintFullName();
        }
    }

    public class employee 
    {
        public string Fname;
        public string Lname;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(Fname + " " + Lname);
        }
    }

    public class partTimeEmp : employee
    {
    /// <summary>
    /// 1.let's say that if we hire a new partTimeEmp and when we print their names (i.e. PTE.PrintFullName()) we want all the partTimeEmp to 
    /// show the word contractor i.e. it will print "Part Time - Contractor" but only for part time so we create a new method called the same 
    /// name as in the base class and we add the word new in front of it. if we dont do this then the below PrintFullName will hide the one 
    /// from above when printing the name of the PTE. The reason we put a new is because the compiler will now explicitly know to hide the 
    /// base class PrintFullName for PTE and will use its own PrintFullName method
    /// </summary>
        public new void PrintFullName()
        {
            Console.WriteLine(Fname + " " + Lname + " - Contractor");
            //base.PrintFullName(); //2.if we want to call a base method (for some reason) we can just put the "base." word in front and call
                                  //the method
        }
    }

    public class fullTimeEmp : employee
    {

    }
}
