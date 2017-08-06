using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverloading
{
    class methodOverloading
    {
        static void Main()
        {
            //add();
        }

        public static void add(int fn, int sn)
        {
            Console.WriteLine("sum = {0}", fn + sn);
        }

        public static void add(int fn, int sn, int tn)
        {
            Console.WriteLine("sum = {0}", fn + sn + tn);
        }

        public static void add(int fn, int sn, int tn, int fourthnum)
        {
            Console.WriteLine("sum = {0}", fn + sn + tn + fourthnum);
        }

        //1. In the above methods, they are all overloaded based on the parameters given. If in the Main method i want to add 3 numbers then the compiler
        //will call the add method that has 3 params. Below is how we can overload methods based on data types

        public static void add(float fn, float sn)
        {
            Console.WriteLine("sum = {0}", fn + sn);
        }

        public static void add(int fn, float sn)
        {
            Console.WriteLine("sum = {0}", fn + sn);
        }

        /// <summary>
        /// 2. in this part both the methods have 3 params but one is an output type and the other is just 3 int params
        /// </summary>

        public static void add(int fn, int sn, int Tn)
        {
            Console.WriteLine("sum = {0}", fn + sn);
        }

        public static void add(int fn, int sn, out int sum)
        {
            Console.WriteLine("sum = {0}", fn + sn);
            sum = fn + sn;
        }
    }
}
