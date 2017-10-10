using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace passingDataToThreadFunction
{
    class passingDataToThreadFunction
    {
        public static void Main()
        {
            ///<summary>
            ///To pass data to the thread function in a type safe manner, encapsulate the thread function and the data it needs in a helper class and use the
            ///ThreadStart delegate to execute the thread function
            ///</summary>
            
            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            Number numb = new Number(target);
            Thread t1 = new Thread(new ThreadStart(numb.PrintNumbers));
            t1.Start();
        }
    }
    
    //1. here we have a helper class called Number which will contain the thread function. In this case, the thread function will be the PrintNumber method. 
    //the way this function will work is that we will print up to a certain number which will be the target and to hold that target number we will use a
    //a private field which is '_target'. and to initilize the private field we will use a constructor to set the target number.
    public class Number
    {
        private int _target;
        public Number(int target)
        {
            this._target = target;
        }

        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
