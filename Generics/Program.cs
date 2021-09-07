using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>(5);
            sayilar.Add(5);
            sayilar.Add(2);
            sayilar.Add(4);
            sayilar.Add(3);
            sayilar.Add(9);
            
            Console.Write("Foreach loop: ");
            foreach (var sayi in sayilar)
            {
                Console.Write(sayi + " | ");
            }
            
            Console.WriteLine();
            
            Console.Write("ForEach Method: ");
            sayilar.ForEach(sayi => Console.Write(sayi + " | "));
            Console.WriteLine();
            
            List<Users> users = new List<Users>();
            Users user1 = new Users();

            user1.Isim = "Ulaş";
            user1.Yas = 20;
            user1.Sehir = "Ankara";

            users.Add(user1);
            //users.Add(5); User class ının elemanı olmayan eklenemez
            users.Add(new Users()
            {
                Isim = "Ömer",
                Yas = 21,
                Sehir = "İstanbul"
            });
            
            Console.WriteLine(users[0].Isim);
            users.ForEach(user => Console.WriteLine($"{user.Isim}, {user.Sehir}, {user.Yas}"));

        }
    }

    
    public class Users
    {
        private string _isim;
        private int _yas;
        private string _sehir;
        
        
        public string Isim
        {
            get => _isim;
            set => _isim = value;
        }
        public int Yas
        {
            get => _yas;
            set => _yas = value;
        }
        public string Sehir
        {
            get => _sehir;
            set => _sehir = value;
        }
    }
}