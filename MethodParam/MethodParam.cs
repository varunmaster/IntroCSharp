using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParam
{
    class MethodParam
    {
        static void Main()
        {
            int i = 0;              //i and j are both initially pointing to 0. Then we tell i to point to 101 and j points to that as well
            SimpleMethod(ref i);
            //Console.WriteLine(i);

            int add = 0;
            int multiplication = 0;

            sum(10, 20, out add, out multiplication);
            //Console.WriteLine(add + " " + multiplication);

            int[] numbs1 = new int[] { 101, 102, 103 };
            ParamsMethod(4,numbs1);
            ParamsMethod(0,1,2,3,4,5,6,7,8,9);
        }

        public static void SimpleMethod(ref int j) //this is a reference parameter. 
        {
            j = 101; //simply change 
        }

        public static void sum(int FN, int SN, out int sum, out int Product) //use 'out' if you want to return more than one value
        {
            sum = FN + SN;
            Product = FN * SN;
        }

        public static void ParamsMethod(int x, params int [] numb)
        {
            Console.WriteLine(x);
            Console.WriteLine("Length of array is " + numb.Length);
            foreach (int i in numb)
            {
                Console.WriteLine(i);
            }
        }
    }
}
