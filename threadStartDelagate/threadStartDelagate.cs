using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threadStartDelagate
{
    class threadStartDelagate
    {
        public static void Main()
        {
            //Thread t1 = new Thread(Numbers.PrintNumbers);
            //1. here we are using a delegate called ThreadStart that points to our function. In general, whenever starting a new thread a delegate MUST be used
            //to start it.
            Thread t1 = new Thread(new ThreadStart(Numbers.PrintNumbers));
            t1.Start();

            Console.WriteLine("Please enter a number to stop the count");
            object target = Console.ReadLine();

            //ParameterizedThreadStart PTS = new ParameterizedThreadStart(Numbers1.PrintNumbers1);
            Thread t2 = new Thread(Numbers1.PrintNumbers1);
            t2.Start(target);
        }
    }

    public class Numbers
    {
        public static void PrintNumbers()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Numbers1
    {
        public static void PrintNumbers1(object target)
        {
            int numb = 0;
            if (int.TryParse(target.ToString(), out numb))
            {
                for (int i = 1; i <= numb; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Input cannot be converted to number. please use a number");
            }
        }
    }
}
