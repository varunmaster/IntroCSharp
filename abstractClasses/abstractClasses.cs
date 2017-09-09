using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClasses
{
    /// <summary>
    /// The main differences between abstract classes and interfaces are that abstract classes can have implimentations for methods (print2) only but
    ///  interfaces cannot have any implimentation at all. Interfaces are public by default and therefore you cannot add a access modifier, abstract
    ///  classes can have access modifiers. Abstract classes can have fields (int ID) but interfaces cannot have fields. 
    /// </summary>
    public class abstractClasses : customer //2. since we are inheriting from an abstract class, we have provide implimentation for its methods/members
    {
        public static void Main()
        {
            customer AC = new abstractClasses();
            AC.Print();
        }

        public override void Print()
        {
            Console.WriteLine("print abstract method");
        }
    }

    public abstract class customer //1. abstract classes are incomplete. no implimentation. cannot be used to create instances
    {
        public abstract void Print(); 

        public void print2()
        {
            Console.WriteLine("print2 method");
        }
    }
}