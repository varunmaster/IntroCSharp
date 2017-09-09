using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicitInterface
{
    class explicitInterface : I1, I2
    {
        static void Main()
        {
            explicitInterface e1 = new explicitInterface();
            ((I1)e1).interfaceMethod();//4. one way to ensure we are using I1 interface is use the typecast operator. Or we can change it like the we did in 5
            ((I2)e1).interfaceMethod();

            I1 i1 = new explicitInterface(); //6. or you can do it like this instead of using the type cast operator
            i1.interfaceMethod();

            I2 i2 = new explicitInterface();
            i2.interfaceMethod();

            explicitInterface e2 = new explicitInterface();
            e2.interfaceMethod();//8. the default interface used will be I1
            ((I2)e2).interfaceMethod();//9. this is excpilicit interface implimentation 
        }

        //public void interfaceMethod()//2. we can now do something with the interface method that we created in I1
        public void interfaceMethod()//7. this will be the default impliementation that will be used. see number 8
        {
            Console.WriteLine("I1 interface method");
        }

        void I2.interfaceMethod()//5. to explicitly impliment the I1 method, we first remove the public access modifier, then we put a I1 in front
        {
            Console.WriteLine("I2 interface method");
        }
    }

    interface I1
    {
        void interfaceMethod(); //1. interfaces can only have declarations. so in order to do something with this method, we have to use it in another class
                                //with the same method name. 
    }

    interface I2//3. now lets say that we have 2 interfaces, that have the same interfaces. when we run this method in a class, we wont know which 
                //interfaceMethod() it is using. 
    {
        void interfaceMethod();
    }
}
