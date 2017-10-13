using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace protectingSharedResourcesFromConcurrentAccessinMultithreading
{
    class protectingSharedResourcesFromConcurrentAccessinMultithreading
    {
        static int total = 0;
        public static void Main()
        {
            AddOneMillion();
            AddOneMillion();
            AddOneMillion();
            Console.WriteLine("Total = " + total);
        }

        public static void AddOneMillion()
        {
            for(int i = 1; i <= 1000000; i++)
            {
                total++;
            }
        }
    }
}
