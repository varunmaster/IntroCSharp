using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace optionalParameters
{
    class optionalParameters
    {
        public static void Main()
        {
            addNumbers(1, 2);
            addNumbers(1, 2, 3);
            //addNumbers(1, 2, new object[] {3, 4, 5});
        }
        /// <summary>
        /// 1. here we have a method where we want to add two numbers but there is also a possibility that we want to add more than 2 numbers so we make 
        /// the other parameters optional by putting them in an object array 
        /// </summary>
        #region addNumbers method
        //public static void addNumber(int FN, int SN, [Optional] int[] otherNumbs)
        public static void addNumbers(int FN, int SN, params object[] otherNumbs)
        {
            int result = FN + SN;
            if(otherNumbs != null)
            {
                foreach (int i in otherNumbs)
                    result += i;
            }

            Console.WriteLine("sum = " + result);
        }
#endregion
    }
}
