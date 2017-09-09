using System;
using assemblyOne;

namespace assemblyTwo
{
    public class assemblyTwoClass1
    {
        public void Print()
        {
            assemblyOneClass1 A1 = new assemblyOneClass1();
            //This will throw an error because we are not deriving from the assemblyOneClass1 from the assemblyOne class
            //A1.ID = 101; 
        }
    }

    /// <summary>
    /// in this class we are inheriting from the assemblyOneClass1 and now we are able to access ID even though it has an protected internal access
    /// modifier to it. We can now access this ID because we are inheriting from that class and use the base keyword.
    /// </summary>
    public class assemblyTwoClass1a : assemblyOneClass1
    {
        public void Print1()
        {
            assemblyOneClass1 A1 = new assemblyOneClass1();
            base.ID = 101;
        }
    }
}