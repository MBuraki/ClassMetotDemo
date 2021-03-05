using System;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri customer)
        {
            Console.WriteLine("Kaydınız Oluşturuldu." + customer.MusteriAdi);
        }
        public void Listele(Musteri customer) 
        {
            Console.WriteLine("Müşteri Listelendi." + customer.MusteriAdi + " " + customer.MusteriSoyadi     );
        }
        public void Sil(Musteri customer)
        {
            Console.WriteLine("Müşteri silindi." + customer.MusteriAdi + " " + customer.MusteriSoyadi);
        }
            
    }
}
