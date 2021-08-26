using System;

namespace for_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());
            int tekToplam = 0;
            int ciftToplam = 0;

            Console.WriteLine("Tek ve Çift sayı toplamlarını öğrenmek istediğiniz sayıyı giriniz");

            for (int i = 0; i <= sayi; i++)
            {
                if (i%2 == 0)
                {
                    tekToplam+= i;
                }

                if (i%2 != 0)
                {
                    ciftToplam+= i;
                }

                Console.WriteLine("Tek sayılar: {0} | " + "Çift Sayılar: {1}",tekToplam,ciftToplam);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                if (i == 2)
                {
                    Console.WriteLine("Döngüden Çıkılıyor....");
                    break;
                }
            }            
        }
    }
}
