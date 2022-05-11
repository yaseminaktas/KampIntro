using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi.");
            Console.WriteLine("Hoşgeldiniz : " + customer.Name + " " + customer.Surname);
            Console.WriteLine("Id Numaranız : " + customer.Id);
            Console.WriteLine("Yaşınız ve Telefon Numaranız : " + customer.Age + " & " + customer.Phone);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi.");
            Console.WriteLine("Silindi-->" + customer.Name + " " + customer.Surname);
            Console.WriteLine("Silinen Müşterinin Id Numarası : " + customer.Id);
            Console.WriteLine("Silinen Müşterinin Yaşı ve Telefon Numarası : " + customer.Age + " & " + customer.Phone);
        }

        public void CustomerList(Customer customer)
        {

            Console.WriteLine("Müşteri'nin Adı Soyadı : " + customer.Name + " " + customer.Surname);
        }
    }
}
