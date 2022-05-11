using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //imzanın aynı olduğu ama içerisinin farklı olduğu durumlarda base de oluşturduğumuz classı class olarak değil interface olarak kullanırız.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

        //interfaceleri birbirinin alternatifi olan fakat kod içerikleri farklı olan durumlar için kullanırız.
        
    }
}
