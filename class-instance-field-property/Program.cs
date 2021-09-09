using System;

namespace class_instance_field_property
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
            //  [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //  [Erişim Belirleyici] [Geri Dönüş Tipi] MethodAdi([Parametre Listesi])
            //  {
            //  Metot Komutları
            //  }
            //}

            //Erişim Belirleyici
            //public
            //private
            //internal
            //protected
            
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ulaş Doğan";
            calisan1.Soyad = "Deniz";
            calisan1.No = 213865;
            calisan1.Departman = "IT";

            calisan1.BilgileriGetir();
            Console.WriteLine();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ömer";
            calisan2.Soyad = "Batıgün";
            calisan2.No = 14654987;
            calisan2.Departman = "Sağlık";

            calisan2.BilgileriGetir();
        }
    }
    class Calisan
    {
        //properties
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void BilgileriGetir(){
            
            Console.WriteLine($"Çalışan Adı:{Ad}");
            Console.WriteLine($"Çalışan Soyadı:{Soyad}");
            Console.WriteLine($"Çalışan Numarası:{No}");
            Console.WriteLine($"Çalışan Departmanı:{Departman}");
        }
    }
}