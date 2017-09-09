using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes
{
    class attributes
    {
        public static void Main()
        {
            calculator.Add(10, 20);
            //calculator.Add(10, 20, 30);
            calculator.Add(new List<int>() { 10, 20, 30, 40, 50 });
        }
    }

    /// <summary>
    /// 1. here we just have a simple class that has a simple method where it adds two or three numbers. the issue with this is that what if the user wants
    /// to add more than 2 or 3 numbers? this is when we use list that can hold and undefined number of numbers and then just add. Now that we used the 
    /// list way of summing, the other methods are now obsolete. So now we must tell the compiler this is an obsolete method and should use the new one 
    /// but we must leave the old methods in there for backwards compatibility. If we use the method where we give true as another paramter, what it does is
    /// it tells the program that wheneever you see the user using the old obselete method, throw an error. So in the line where we said 
    /// "calculator.Add(10, 20, 30);" it will throw an error and give the message we chose.
    /// </summary>
    public class calculator
    {
        [Obsolete("This is an old method. Use Add(List<int> Numbers) method")]
        public static int Add(int FN, int SN)
        {
            return FN + SN;
        }
        [Obsolete("This is an old method. Use Add(List<int> Numbers) method", true)]
        public static int Add(int FN, int SN, int TN)
        {
            return FN + SN + TN;
        }
        public static int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach (int n in Numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}
