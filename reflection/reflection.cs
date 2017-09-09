using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflection
{
    class reflection
    {
        /// <summary>
        /// 1. Our objective is to be able to print out all the of classes, attributes, methods, etc within this namespace. The way to do this is by using 
        /// reflection. Reflection is inspecting an assemblies' (.exe for console application and .dll for web-based) metadata at runtime. A real world 
        /// example of this is when you are creating a console application, there is a little properties menu that shows up and displays a buttons' 
        /// properties, it is done using this.
        /// </summary>
        public static void Main()
        {
            Type T = Type.GetType("reflection.customer");
            //Type T = typeof(customer);
            Console.WriteLine("Full name = {0}", T.FullName);
            Console.WriteLine("name = {0}", T.Name);
            Console.WriteLine("namespace = {0}", T.Namespace);
            Console.WriteLine();

            Console.WriteLine("Properties:");
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo PI in properties)
            {
                Console.WriteLine(PI.PropertyType.Name + " " + PI.Name);
                Console.WriteLine(PI.Attributes);
            }

            Console.WriteLine();
            Console.WriteLine("Methods:");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo MI in methods)
            {
                Console.WriteLine(MI.ReturnType + " " + MI.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Constructors:");
            ConstructorInfo[] consturctorinfo = T.GetConstructors();
            foreach (ConstructorInfo CI in consturctorinfo)
            {
                Console.WriteLine(CI.ToString());
            }
        }
    }

    public class customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public customer(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public customer()
        {
            this.ID = -1;
            this.Name = string.Empty;
        }

        public void printID()
        {
            Console.WriteLine("ID = {0}", this.ID);
        }

        public void printName()
        {
            Console.WriteLine("ID = {0}", this.Name);
        }
    }
}
