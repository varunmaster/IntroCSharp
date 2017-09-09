using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicastDelegate
{
    public delegate void sampleDelegate();
    public delegate int sampleDelegateNumb();

    class multicastDelegate
    {
        public static void Main()
        {
            ///<summary>
            ///0. multicast delegates are delegates that has references to more than one function. When you invoke that one delegate, all of functions will
            ///be invoked
            ///</summary>

            //sampleDelegate del = new sampleDelegate(sampleMethod1); //1. in the parenthesis we put the function that we want the delegate to point to
            //del();
            //sampleDelegate del1, del2, del3, del4;
            //del1 = new sampleDelegate(sampleMethod1);
            //del2 = new sampleDelegate(sampleMethod2);
            //del3 = new sampleDelegate(sampleMethod3);

            //del4 = del1 + del2 + del3; //2. del4 now points to all 3 other delegates so when del4 is invoked, del1, del2, del3 are all invoked at once
            //del4();                    //to multicast delegates, just use the plus sign

            sampleDelegate del = new sampleDelegate(sampleMethod1);
            del += sampleMethod2; //3. we are using the single instance to call other methods
            del += sampleMethod3;

            del();

            sampleDelegateNumb delNumb = new sampleDelegateNumb(sampleMethodNumb1); //4. if the return type of delegate is anything other than void and 
                                                                                    //is a multicast delegate only the last invoked method will return
            delNumb += sampleMethodNumb2;

            int retrunDelNumb = delNumb();
            Console.WriteLine(retrunDelNumb);
        }

        public static void sampleMethod1()
        {
            Console.WriteLine("sampleMethod1 invoked");
        }

        public static void sampleMethod2()
        {
            Console.WriteLine("sampleMethod2 invoked");
        }

        public static void sampleMethod3()
        {
            Console.WriteLine("sampleMethod3 invoked");
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public static int sampleMethodNumb1()
        {
            return 1;
        }

        public static int sampleMethodNumb2()
        {
            return 2;
        }
    }

    
}
