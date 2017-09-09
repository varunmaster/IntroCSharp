using System;

namespace assemblyOne
{
    public class assemblyOneClass1
    {
        //1. this ID field is only accessable within this assemblyOne class and cannot be used anywhere else. 
        //internal int ID = 101;

        //2. this ID field can now be accessed anywhere where the reference of assemblyOne is added (such as in assemblyTwo) as long as the second class is
        //deriving from this one.
        protected internal int ID = 101;
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