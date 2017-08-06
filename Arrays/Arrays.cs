using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Arrays
    {
        static void Main()
        {
            int[] evenNumb = new int[3];

            evenNumb[0] = 0;
            evenNumb[1] = 2;
            evenNumb[2] = 4;

            //creating a 2D array wihtout specified dimensions:
            int[,] array2d = new int[,] { { 1, 2 }, 
                                          { 3, 4 }, 
                                          { 5, 6 } };

            //creating a 3D array:
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                            { { 7, 8, 9 }, { 10, 11, 12 } } };
        }
    }
}
