using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class delegates
    {
        public static void Main()
        {
            //1. a delegate is a type safe function pointer. This means that a delegate points to a function and then when invoked, the funtion will be
            //invoked. THE SIGNATURE OF THE DELEGATE MUST MATCH THE SIGNATURE OF THE FUNCTION.

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("test from delegate");
        }

        public static void Hello (string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

    public delegate void HelloFunctionDelegate(string message); //2. this delegate can be used to any function that has the same signature. in this case 
                                                                //it is a function that has void return type and a string parameter. 
}
