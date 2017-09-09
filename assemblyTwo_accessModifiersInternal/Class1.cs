using System;
using assemblyOne_accessModifiersInternal;

namespace assemblyTwo_accessModifiersInternal
{
    public class AssemblyTwoClass
    {
        public void test()
        {
            AssemblyOneClass A1C = new AssemblyOneClass();
            A1C.Print();
        }
    }
}
