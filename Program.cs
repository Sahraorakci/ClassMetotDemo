using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ayşe";
            musteri1.Yasi = 25;
            musteri1.Bakiye = 10000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Adi = "Fatma";
            musteri2.Yasi = 30;
            musteri2.Bakiye = 50000;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2};

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle();
            musteriManager.Sırala(musteriler);
            


        }
        
    }
}
