using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Lists
    {
        public static void Main()
        {
            customer c1 = new customer()
            {
                ID = 101,
                Name = "Rich",
                Salary = 5000
            };
            customer c2 = new customer()
            {
                ID = 110,
                Name = "Joe",
                Salary = 7000
            };
            customer c3 = new customer()
            {
                ID = 111,
                Name = "Leslie",
                Salary = 9000
            };

            //1. Here we are specifying a list with a size of 2 but then we are adding 3 objects to the list. Since this is a list, it grows without limit even
            //if you specify a size. The same thing cannot be done with arrays because if you sepcify an array of length x then it can only grow to x size and
            //cannot be dynamically grown. (however if you dont specify an array length it will work as well but its better to use a list if you dont know 
            //how many items you are going to be adding)
            List<customer> custList = new List<customer>(2);
            custList.Add(c1);
            custList.Add(c2);
            custList.Add(c3);

            customer c = custList[0];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);

            foreach (customer CL in custList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", CL.ID, CL.Name, CL.Salary);
            }

            //2. since we specified that the list is going to only contain objects of type Customer, adding anything else to the list will give a compile error
            //However, if you add things to the list that inherit from the base class (that the list is specified) then it will work. Below is an error and 
            //one that works
            //custList.Add(101);
            savingsCustomer sc = new savingsCustomer();

            custList.Add(sc);

            if (custList.Contains(c3))
            {
                Console.WriteLine("Customer 3 exists in the list");
            }
            else
            {
                Console.WriteLine("Customer 3 does not exist");
            }
        }

        public class customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }

        public class savingsCustomer : customer { }
    }
}
