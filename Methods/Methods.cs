using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Methods
    {
        public static void Main()
        {
            EvenNumbers(30); //becauase we are in the same class, we can just call it by the name. If we go to another class then we have to use Methods.EvenNumbers()

            Methods m = new Methods(); //*****to call an Instance of a method, then you have to essentially "create" a new instance by calling
            int sum = m.Add(10, 30);   //the class again (ie Methods) and then using that instance*****
            Console.WriteLine(sum);
        }

        public int Add(int FN, int SN) //this is creating an Instance of the method Add. Also, the int next to public is saying that we are
        {                              //expecting to return an integer. *****To call this function, we have to createa new instance of the class*****
            return FN + SN;
        }

        public static void EvenNumbers(int Target) //public means that this method can be called from anywhere. Void means it's not returning anything
        {                                          //*****static means it can invoked using the name of the calss (ie Methods.EvenNumbers() )*****
            int start = 0;

            while (start <= Target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
