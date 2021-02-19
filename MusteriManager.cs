using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle()
        {
            Console.WriteLine("Yeni Müşteri Eklendi");
        }
        public void Sırala(Musteri[] musteriler)
        {
            
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad:" + musteri.Adi +"Bakiyesi"+ musteri.Bakiye);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
