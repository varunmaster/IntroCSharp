using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    /// <summary>
    /// 1. Lets say we have a method where we want to compare 2 numbers and decided if they are the same or now. then we create a method that does this
    /// but now lets say we want to compare 2 string, we cant used the old method because it only compares integers. so if we convert it to object, then
    /// at compile time, it will convert the arguments to objects and then compare them. but the problem with this is that if the user puts in a integer
    /// and a string then, then it cause problems. so this is where generics come in. Generics allow us to have our own type which is between the carrots
    /// which allows us to specify whatever type we want. This is essentially saying we have a calculate class will take in type integer/string/float/etc
    /// and then we can call that method and specify the type and compare. 
    /// </summary>
    class genrics
    {
        private static void Main()
        {
            //bool equal = calculator.isEqual("A", "A");
            //bool equal = calculator.isEqual<string>("A", "A");
            bool equal = calculator<string>.isEqual("A", "A");

            if (equal)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Flase");
            }
        }
    }

    public class calculator<T>
    {
        //public static bool isEqual(int val1, int val2)
        //public static bool isEqual(object val1, object val2)
        public static bool isEqual(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
}
