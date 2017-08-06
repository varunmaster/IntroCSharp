using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonOps
{
    class CommonOps
    {
        static void Main()
        {
            int numb = 10;
            bool IsNumb10;

            if (numb == 10)
            {
                IsNumb10 = true;
            }
            else
            {
                IsNumb10 = false;
            }

            Console.WriteLine("Numb = 10 is {0}", IsNumb10);

            //This whole program can be shortened with the ternary operator. In this part it is saying that "if number == 10 then true, else false. True value always
            //comes first after the question mark and 

            int number = 10;
            bool IsNumber = (number == 10 ? true : false);

            Console.WriteLine("Number = 10 is {0}", IsNumber);
        }
    }
}
