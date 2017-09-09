using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main()
        {
            customer c1 = new customer();
            c1.print();
        }
    }

    interface ICustomer //1. interfaces can only contain declarations. no implimentation, no fields. public by default, no public access modifier needed.
    {
        void print(); //2. this is a declaration. return type of method, method, and no curly braces
    }

    interface I2
    {
        void I2Method();
    }

    public class customer : ICustomer, I2 //3. a class can inherit from multiple interfaces
    {
        public void print()
        {
            Console.WriteLine("interface print method");
        }

        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }
    }

    public class sample
    {

    }
}