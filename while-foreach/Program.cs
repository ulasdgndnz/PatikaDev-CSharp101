using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, toplam;
            string cevap;
            while (true)
            {
                Console.WriteLine("Toplamak istediğiniz 3 sayıyı giriniz");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = int.Parse(Console.ReadLine());
                toplam = x + y + z;
                
                Console.WriteLine("Toplamı: " + toplam);
                Console.WriteLine("çıkmak için q yazın");
                cevap = Console.ReadLine();
                if (cevap == "q")
                {
                    break;
                }
            }
            
            Console.WriteLine("Harflerini görmek istediğiniz kelimeyi girin");
            string harfler = Console.ReadLine();
            foreach (var harf in harfler)
            {
                Console.WriteLine(harf);
            }
            
        }
    }
}