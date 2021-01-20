using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static Musteri MusteriEkle (int id, string MusteriAdi, string MusteriSoyadi, int Yas)
        {
            Musteri musteri = new Musteri();
            musteri.id = id;
            musteri.MusteriAdi = MusteriAdi;
            musteri.MusteriSoyadi = MusteriSoyadi;
            musteri.Yas = Yas;

            return musteri;
        }
        public static void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Adi" + " : " + musteri.MusteriAdi);
            Console.WriteLine("Müşterinin Soyadi" + " : " + musteri.MusteriSoyadi);
            Console.WriteLine("Müşterinin Yaşı" + " : " + musteri.Yas);
            Console.WriteLine("---------------------------------");
        }

    }
}
