using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class queue
    {
        public static void Main()
        {
            Customer c1 = new Customer()
            {
                ID = 100,
                Name = "Leslie",
                Gender = "Female"
            };

            Customer c2 = new Customer()
            {
                ID = 101,
                Name = "Rich",
                Gender = "Male"
            };

            Customer c3 = new Customer()
            {
                ID = 102,
                Name = "Jack",
                Gender = "Male"
            };

            Customer c4 = new Customer()
            {
                ID = 103,
                Name = "Sophie",
                Gender = "Female"
            };

            Customer c5 = new Customer()
            {
                ID = 104,
                Name = "Danielle",
                Gender = "Female"
            };

            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(c1);
            queueCustomers.Enqueue(c2);
            queueCustomers.Enqueue(c3);
            queueCustomers.Enqueue(c4);
            queueCustomers.Enqueue(c5);

            //1. When we "dequeue" a customer from the queue, it will move the others in the queue up one and then when we put the customer back in the queue
            //that object will be at the end of the list now. Before in a list we would just point to a customer. To do the same, we can use the peek method
            Customer cust1 = queueCustomers.Dequeue();
            Console.WriteLine(cust1.ID + " - " + cust1.Name);
            Console.WriteLine("Total queue is = " + queueCustomers.Count);

            Customer cust2 = queueCustomers.Dequeue();
            Console.WriteLine(cust2.ID + " - " + cust2.Name);
            Console.WriteLine("Total queue is = " + queueCustomers.Count);

            Customer cust3 = queueCustomers.Peek();
            Console.WriteLine(cust3.ID + " - " + cust3.Name);
            Console.WriteLine("Total queue is = " + queueCustomers.Count);

            //2. the foreach loop just loops through the queue and returns it. it does not remove it from the queue. similar to the peek method.
            //foreach (Customer cus in queueCustomers)
            //{
            //    Console.WriteLine(cus.ID + " - " + cus.Name);
            //    Console.WriteLine("Total queue is = " + queueCustomers.Count);
            //}
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
