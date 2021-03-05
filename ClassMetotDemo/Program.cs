using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "M.Burak";
            musteri1.MusteriSoyadi = "Davun";
            musteri1.MusteriYasi = 25;
            musteri1.MusteriMeslek = "Engineer";
            musteri1.MusteriTelefonNo = 261197;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Songül";
            musteri2.MusteriSoyadi = "Ekinci";
            musteri2.MusteriYasi = 24;
            musteri2.MusteriMeslek = "Dış Ticaret Personeli";
            musteri2.MusteriTelefonNo = 030696;

            Console.WriteLine("------müşteri ekleme------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("------listeleme------");

            Musteri[] musteriler = new[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.MusteriYasi);
                Console.WriteLine(musteri.MusteriMeslek);
                Console.WriteLine(musteri.MusteriTelefonNo);
            }

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            Console.WriteLine("------müşteri silme------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

        }
    }
}
