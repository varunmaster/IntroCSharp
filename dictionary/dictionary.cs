using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace dictionary
{
    class dictionary
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

            Dictionary<int, customer> dictionaryCustomer = new Dictionary<int, customer>();
            dictionaryCustomer.Add(c1.ID, c1);
            dictionaryCustomer.Add(c2.ID, c2);
            dictionaryCustomer.Add(c3.ID, c3);
            //This checks if a dictionary already has this ID in there
            if (!dictionaryCustomer.ContainsKey(c1.ID))
            {
                dictionaryCustomer.Add(c1.ID, c3);
            }

            customer cust111 = dictionaryCustomer[111];
            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust111.ID, cust111.Name, cust111.Salary);

            foreach (KeyValuePair<int, customer> customerKeyValuePair in dictionaryCustomer)
            {
                Console.WriteLine("ID = {0}", customerKeyValuePair.Key);
                customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }
        }

        public class customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
    }
}
