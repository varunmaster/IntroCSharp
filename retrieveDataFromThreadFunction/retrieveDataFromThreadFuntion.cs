using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace retrieveDataFromThreadFunction
{

    public delegate void sumOfNumbersCallback(int sumOfNumbers);

    class retrieveDataFromThreadFuntion
    {
        /// <summary>
        /// Our main objective is to promot the user to enter a number and a method will add all the numbers from 0 to the user input and retive the sum of
        /// those numbers.
        /// </summary>

        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum = " + sum);
        }
        public static void Main()
        {
            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            sumOfNumbersCallback callback = new sumOfNumbersCallback(PrintSum);

            Number numb = new Number(target, callback);
            Thread t1 = new Thread(new ThreadStart(numb.PrintSumOftNumbers));
            t1.Start();
        }
    }

    public class Number
    {
        private int _target;
        sumOfNumbersCallback _callBackMethod;

        public Number(int target, sumOfNumbersCallback callBackMethod)
        {
            this._target = target;
            this._callBackMethod = callBackMethod;
        }

        public void PrintSumOftNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum += i;
            }

            if (_callBackMethod != null)
                _callBackMethod(sum);
        }
    }
}
