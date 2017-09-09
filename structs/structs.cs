using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs
{
    /// <summary>
    /// 0. The difference between a struct and class is that a struct is a VALUE TYPE and a class is REFERENCE TYPE. This means that a struct is stored on
    /// the stack. A stack is static meaning that it holds information in a definite spot in the memory (i.e. int x = 10 and int y = 20;). This means that
    /// when accessing x and y, the computer is quick to return a value since it is static (it does not change); think of this where only local variables
    /// are stored. 
    /// A class is stored on the heap. A heap is memory allocation where global variables can be stored. This is a bit slower but is more dynamic when using
    /// classes.
    /// </summary>
    class structs
    {
        static void Main()
        {
            customer c1 = new customer(101, "Jeff");//3. Here we are using a constructor to pass the arguments
            c1.printDetail();

            customer c2 = new customer();//4. Here we are using the default contstructor and using the properties of the structure to initialize the fields
            c2.ID = 102;
            c2.Name = "John";
            c2.printDetail();

            //5. this is using object initializer syntax which can be used for either struct or class
            customer c3 = new customer
            {
                ID = 103,
                Name = "Jake"
            };
            c3.printDetail();
        }
    }

    public struct customer
    {/// <summary>
    /// 1. we have a customer class that stores info about them. Theses fields cannot be empty and SHOULD NOT be able to be overwritten by the user.
    /// To prevent the user from changing or accessing these fields, we must encapsulate them with similar fields that the user can use with get and set.
    /// Encapsulation is basically protecting the private fields so no one can change it. 
    /// </summary>
        private int _ID;
        private string _name;

        public int ID
        {
            get { return this._ID; }
            set { this._ID = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// 2. We are using a constructor to initialize the private fields.
        /// </summary>
        public customer(int ID, string Name)
        {
            this._ID = ID;
            this._name = Name;
        }

        public void printDetail()
        {
            Console.WriteLine("Id = {0} and name = {1}", this._ID, this._name);
        }
    }
}
