using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class NullableType
    {
        static void Main()
        {
            //Integer is a non-nullable value. This means that it cannot be null and must hold a value such as 0 or 290. Default value for int, float, double, etc are 0.
            //Value Types = int, float, double, structs, enums etc
            //Refrence Types can hold null values
            //int i = null;
            string name = null;

            //To value types equal to be null or be nullable use ? 
            int? j = null;

            bool? major = null;
            if (major == true)
            {
                Console.WriteLine("Yes major");
            }
            else if (major == false)
            {
                Console.WriteLine("Not major");
            }
            else
            {
                Console.WriteLine("null");
            }

            //Here is an example of converting a nullable data type into a non-nullable data type
            int? TicksOnSale = null;
            int AvailableTicks;

            if(TicksOnSale == null)
            {
                AvailableTicks = 0;
            }
            else
            {
                //AvailableTicks = TicksOnSale; //This gives an error because we are saying that a non-nullable data type can be a nullable data type
                AvailableTicks = (int)TicksOnSale; //This is allowed and legal because even though TicksOnSale is nullable, we are "converting" to int before we assign it to AvailableTicks
            }

            Console.WriteLine("AvailableTicks = {0}", AvailableTicks);

            //This is a more efficient way of writing the above using a Null Coalescing Operator
            int AvailableTicks1 = TicksOnSale ?? 0; //This is saying that if TicksOnSale is null then assign it the value 0 or else it is equal to TicksOnSale
            

        }
    }
}
