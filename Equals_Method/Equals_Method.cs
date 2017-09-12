using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals_Method
{
    class Equals_Method
    {
        private static void Main()
        {
            int i = 10;
            int j = 10;

            //1. both of these will be the same
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Direction dir1 = Direction.East;
            Direction dir2 = Direction.East;

            Console.WriteLine(dir1 == dir2);
            Console.WriteLine(dir1.Equals(dir2));

            Customer c1 = new Customer();
            c1.FN = "John";
            c1.LN = "Wick";

            //Customer c2 = c1;
            Customer c2 = new Customer(); //2. here we are creating another instance of the customer that hold the same values. The thing to note here is that
                                          //when we write 'Customer c2 = c1' we are creating another variable that is on the stack and both c1 and c2 are 
                                          //referencing the same object on the heap so they will always be the same and the next two lines will always return
                                          //true. However, if we uncomment the new instance, then both c1 and c2 are referencing two different objects in the 
                                          //heap and are not referencing the same object and therefore the next two line will return false even though the 
                                          //values of the objects are the same. the '==' is for reference equality (i.e. both referring to same object or not)
                                          //whereas the equals method gives us the value equality.
            c2.FN = "John";
            c2.LN = "Wick";

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
        }
    }

    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }

    public class Customer
    {
        public string FN { get; set; }
        public string LN { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!(obj is Customer))
            {
                return false;
            }

            return this.FN == ((Customer)obj).FN && this.LN == ((Customer)obj).LN;
        }

        public override int GetHashCode()
        {
            return this.FN.GetHashCode() ^ this.LN.GetHashCode();
        }
    }
}
