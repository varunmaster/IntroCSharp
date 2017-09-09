using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiClassInheritanceWithInterfaces
{
    class multiClassInheritanceWithInterfaces
    {
        public static void Main()
        {
            AB ab = new AB(); //3. here we are just creating a new instance of the class AB and then calling the respective methods
            ab.AMethod();
            ab.BMethod();
        }
    }

    interface IA
    {
        void AMethod();
    }

    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A method from Interface IA");
        }
    }

    interface IB
    {
        void BMethod();
    }

    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B method from interface IB");
        }
    }

    class AB : IA, IB //1. we cannot inherit from multiple clases (A, B) but we can inherit multiple interfaces 
    {
        /// <summary>
        /// 2. since we already have the implimentation in class A and B we dont have to impliment it again. We just have to create a new instance of it 
        /// and use that method that we already created. We are creating a new object a (lower case) that will call the method AMethod from the above 
        /// method
        /// </summary>
        A a = new A();
        public void AMethod()
        {
            a.AMethod();
        }

        B b = new B();
        public void BMethod()
        {
            b.BMethod();
        }
    }
}
