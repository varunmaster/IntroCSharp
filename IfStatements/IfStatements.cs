using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class IfStatements
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int UserNumb = int.Parse(Console.ReadLine()); //can't use (int) Console.ReadLine() 

            if(UserNumb == 1)
            {
                Console.WriteLine("1");
            }
        }
    }
}
