using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 12;

        }
    }

   class Customer
    {
        //defauit constructor
        public Customer()
        {
            Console.WriteLine("yapıcı blok çalıştı");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
