using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialMethods
{
    class partialMethods
    {
        /// <summary>
        /// 1. Here we are calling a method called publicMethod(). The important thing about that method is that it is in separate files. file one contains
        /// only the definition/signature of the method and file two contains the actual implimentation. if we didnt have file two and only fileone with
        /// the definition, the program will still build/run because during compiling, it ignores the part where in the method we call samplePartialMethod()
        /// and ignores the declaration of the method. However, as soon as we add file two, the compiler knows to call that method from the second file and
        /// execute the method. If you have the declaration and the implimentation in the same file, then it will give an error. Partial methods have to be
        /// called within a partial class
        /// </summary>
        static void Main()
        {
            SamplePartialClass SPC = new SamplePartialClass();
            SPC.publicMethod();
        }
    }
}
