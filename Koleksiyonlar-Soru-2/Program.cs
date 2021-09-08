using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write(i);
                int input = int.Parse(Console.ReadLine());
                sayilar[i] = input;
            }
            Array.Sort(sayilar);

            int enKucuk = (sayilar[0] + sayilar[1] + sayilar[2]) / 3;
            int enBuyuk = (sayilar[19] + sayilar[18] + sayilar[17]) / 3;
            Console.WriteLine($"En küçük 3 sayının ortalaması: {enKucuk}, En büyük 3 sayının ortalaması: {enBuyuk}, Toplamı: {enKucuk+enBuyuk}");

        }
    }
}