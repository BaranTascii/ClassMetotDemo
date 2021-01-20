using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = MusteriManager.MusteriEkle(1, "Ahmet", "Şimşek", 35);
            Musteri musteri2 = MusteriManager.MusteriEkle(2, "Esra", "Yılmaz", 32);
            Musteri musteri3 = MusteriManager.MusteriEkle(3, "Seda", "Koç", 22);
            Musteri musteri4 = MusteriManager.MusteriEkle(4, "Mustafa", "Avcı", 26);

            MusteriManager.MusteriListele(musteri1);
            MusteriManager.MusteriListele(musteri2);
            MusteriManager.MusteriListele(musteri3);
            MusteriManager.MusteriListele(musteri4);
        }
    }
}
