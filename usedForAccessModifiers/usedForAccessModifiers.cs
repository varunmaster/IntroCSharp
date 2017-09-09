using System;

namespace usedForAccessModifiers
{
    public class assemblyOneClass1
    {
        //1. this ID field is only accessable within this .cs project
        internal int ID = 101;
    }

    public class assemblyOneClass2
    {
        public void sampleMethod()
        {
            assemblyOneClass1 A1 = new assemblyOneClass1();
            Console.WriteLine(A1.ID);
        }
    }
}
