using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (var customer in customers)
            {
                CustomerManager customerManager = new CustomerManager();
                customerManager.Add(customer);
                Console.WriteLine("");

            }
            foreach (var customer in customers)
            {
                CustomerManager customerManager = new CustomerManager();
                customerManager.Delete(customer);
                Console.WriteLine("");

            }

            Console.WriteLine("Müşteri Listesi : ");
            foreach (Customer customer in customers)
            {
                CustomerManager customerManager = new CustomerManager();
                customerManager.CustomerList(customer);
            }


        }
    }
}
