using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialMethods
{
    public partial class SamplePartialClass
    {
        partial void samplePartialMethod()
        {
            Console.WriteLine("samplePartialMethod() invoked from partialClassfileTwo.cs");
        }
    }
}
