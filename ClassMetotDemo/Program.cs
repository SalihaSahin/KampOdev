using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Saliha";
            musteri1.Soyad = "Şahin";
            musteri1.TelefonNo = 12345678;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "EsmaNur";
            musteri2.Soyad = "Kılıç";
            musteri2.TelefonNo = 87654321;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Gökhan";
            musteri3.Soyad = "Uçak";
            musteri3.TelefonNo = 37463476;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusterileriListele(musteriler);
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSilme(musteri2);

        }
    }
}
