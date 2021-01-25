using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri newMusteri)
        {
            Console.WriteLine(newMusteri.Ad + " " + newMusteri.Soyad + " aramıza hoşgeldiniz :))");
        }
        public void MusteriSilme(Musteri removeMusteri)
        {
            Console.WriteLine(removeMusteri.Ad + " " + removeMusteri.Soyad + " adlı müşteri silindi.");
        }
        public void MusterileriListele(Musteri[] musteriler)
        {

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("***********************************");
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.TelefonNo);
                Console.WriteLine("***********************************");


            }
        }

    }
}
