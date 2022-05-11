using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri customer1 = new GercekMusteri();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "yasemin";
            customer1.Surname = "aktas";
            customer1.TcNo = "12321543";


            TuzelMusteri customer2 = new TuzelMusteri();
            customer2.Id = 2;
            customer2.CompanyName = "mdp";
            customer2.VergiNo = "654";
            customer2.CustomerNo = "654";


            Customer customer3 = new GercekMusteri();
            Customer customer4 = new TuzelMusteri();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Add(customer1);
        }
    }
}
