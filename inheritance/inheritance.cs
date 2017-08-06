using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class inheritance
    { 
    /// 1. <summary>
    /// the purpose of using inheritance is that lets say you want to create 2 separate classes, one for fulltime and one for part-time, you 
    /// then need to create 2 separate classes that has FirstName, LastName, etc but there would only be one small differecnce such as hourly-
    /// wage and yearlywage. Instead of creating 2 classes with the same info about name, we can have one "Base" class which will hold the 
    /// common items and another class that will hold the "differences" (i.e. wages).
    /// </summary>

        static void Main()
        {
            fullTimeEmp FTE = new fullTimeEmp();
            FTE.Fname = "Bjorn";
            FTE.Lname = "BetweenTwoLovers";
            FTE.yearSalary = 70000;
            //FTE.hourlyRate = ; //5. we cannot use this code because the hourlyRate is only available for the partTime employee. 4 lines 
                                 //above this we created a new fullTimeEmp instance so we only have access to base class and whatever
                                 //is in the fullTimeEmp class
            FTE.PrintFullName();

            partTimeEmp PTE = new partTimeEmp();
            PTE.Fname = "Part";
            PTE.Lname = "Time";
            PTE.hourlyRate = 20;
            PTE.PrintFullName();

            intern intern = new intern(); //6. this new intern instance will have access to everything that partTimeEmp has access to which
            intern.Fname = "int";         //also has access to the base/parent class
            intern.Lname = "ern";
            intern.interRate = 15;
            intern.PrintFullName();

            ChildClass CC = new ChildClass();
        }
    }

    public class employee //2. this is creating the BASE class or parent class that will be common between BOTH fulltime and partTime employees
    {
        public string Fname;
        public string Lname;
        public string Email;
        
        public void PrintFullName()
        {
            Console.WriteLine("FullName is {0}", Fname + " " + Lname);
        }
    }

    public class fullTimeEmp : employee //3. this is creating a new "fulltime" class that will inherit properties from the base employee class
    {
        public float yearSalary;
    }

    public class partTimeEmp : employee //4. this is creating a new "partTIme" class that will inherit properties from the base employee class
    {
        public float hourlyRate;
    }

    public class intern : partTimeEmp //6. this is using something called multi-level inheritance where we can use another child class to create
                                      //another child class that also uses a base/parent class
    {
        public float interRate;
    }

    public class ParentClass //7. this is showing that the parent class is always constructed first then the child class is constructed
                             //but if you overload a class then depending on the params you pass will be called.
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass constructor called");
        }
        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived class controlling Parent class") //8. Since we are saying "base(...)" this will call the class
                                                                             //that has string as part of the param. 
                                                                             //http://csharpindepth.com/Articles/General/Overloading.aspx
        {
            Console.WriteLine("ChildClass contstructor called");
        }
    }
}
