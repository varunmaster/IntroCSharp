using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverriding_hidingg
{
    class methodOverriding_hidingg
    {
        static void Main()
        {
            BaseClass B = new DerivedClass();
            BaseClass B1 = new DerivedClass1();
            B.Print();
            B1.Print();
        }
    }

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base class print method");
        }
    }
    /// <summary>
    /// 1. since we put the word override this will run the print method in the chid class since it "overrode the print method in the base class"
    /// </summary>
    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("child class print method");
        }
    }

    /// <summary>
    /// 2. this is called method hiding. In this case when we run line 14, it will invoke the hidden method in the base class because in line 13 we created
    /// we created a base class reference variable that is pointing to a child class object
    /// </summary>
    public class DerivedClass1 : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("child class print method");
        }
    }
}
