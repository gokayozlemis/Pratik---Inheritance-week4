using System;

namespace KisiOrnek
{
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void AdSoyadYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }
    public class Ogrenci : BaseKisi
    {
        public int OgrenciNumarasi { get; set; }

        // öğrenci bilgileri
        public void OgrenciBilgiYazdir()
        {
            AdSoyadYazdir(); //  metodu çağırdım
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
        }
    }

    // basekisi'den miras alan ogretmen sınıfı
    public class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        // öğretmen bilgileri
        public void OgretmenBilgiYazdir()
        {
            AdSoyadYazdir(); // metotdu cagırdım
            Console.WriteLine($"Maaş: {Maas}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // bir öğrenci nesnesi oluşturup değer atama
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = "Gökay",
                Soyad = "Özlemiş",
                OgrenciNumarasi = 12345
            };
            // öğrenci bilgileri
            Console.WriteLine("Öğrenci Bilgileri:");
            ogrenci.OgrenciBilgiYazdir();

            Console.WriteLine();
            // örnek bir öğretmen nesnesi oluşturup değer atama
            Ogretmen ogretmen = new Ogretmen
            {
                Ad = "Sertan",
                Soyad = "Bozkus",
                Maas = 75000
            };
            // öğretmen bilgileri
            Console.WriteLine("Öğretmen Bilgileri:");
            ogretmen.OgretmenBilgiYazdir();

            Console.ReadLine(); // konsolun kapanmasını önlemek için
        }
    }
}