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
}
