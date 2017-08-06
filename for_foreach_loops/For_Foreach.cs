using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_foreach_loops
{
    class For_Foreach
    {
        static void Main()
        {
            int[] numb = new int[3] { 100, 101, 102 };
            /*
            numb[0] = 100;
            numb[1] = 101;
            numb[2] = 102;
            */

            int i = 0;
            while (i < numb.Length)
            {
                Console.WriteLine(numb[i]);
                i++;
            }

            for(int j = 0; j < numb.Length; j++)
            {
                Console.WriteLine(numb[j]);
            }

            foreach(int k in numb)
            {
                Console.WriteLine(k);
            }

            for(int l =1; l <= 20; l++)
            {
                Console.WriteLine(l);
                if (l == 10)
                    break;
            }

            for (int m = 1; m <= 20; m++)
            {
                if (m % 2 == 1) //everytime m iterates, it will check the modulo and if it is equal to 1 then it will go to the continue
                                //which tells the compiler to go back to the for loop and iterate one more time
                    continue;
                Console.WriteLine(m);
            }
        }
    }
}
