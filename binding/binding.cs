using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace binding
{
    class binding
    {
        /// <summary>
        /// 1. here we just have a simple class called Customer with a method that just returns the full name of a customer. In the main method, we are
        /// then creating an instance of the class and then calling the method with 2 params then printing it to the console. This is an example of early
        /// binding. Late binding is when we dont have the knowledge of the class for which we are creating an instance.
        /// </summary>
        private static void Main()
        {
            ///<summary>
            ///2. here we are pretending the customer class doesnt exist yet. 
            ///</summary>
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("binding.customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("getfullname");

            string[] parameters = new string[] {"John", "Wick"};

            string fullName = (string) getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Fullname = {0}", fullName);

            //Customer c1 = new Customer();
            //string Fullname = c1.getFullName("Jon", "Wick");
            //Console.WriteLine("Fullname = {0}", Fullname);
        }
    }

    public class customer
    {
        public string getfullname(string fn, string ln)
        {
            return fn + " " + ln;
        }
    }
}