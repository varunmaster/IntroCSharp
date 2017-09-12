using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString_Method
{
    class ToString_Method
    {
        private static void Main()
        {
            int number = 10;
            Console.WriteLine(number.ToString());//1. the base ToString() method converts the integer to a string value

            Customer c1 = new Customer();
            c1.FN = "Jon";
            c1.LN = "Wick";

            Console.WriteLine(c1.ToString()); //2. because we have the override method below, it will no longer show the base.ToString() method which only
                                              //returned the namespace.class but instead now it will retrun a string format of FN and LN
        }
    }

    public class Customer
    {
        public string FN { get; set; }
        public string LN { get; set; }

        public override string ToString()
        {
            return this.FN + " " + this.FN;
        }
    }
}
