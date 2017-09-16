using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialMethods
{
    public partial class SamplePartialClass
    {
        partial void samplePartialMethod(); //only the declaration/definition here. no implimentation.

        public void publicMethod()
        {
            Console.WriteLine("publicMethod() invoked");
            samplePartialMethod();
        }
    }
}
