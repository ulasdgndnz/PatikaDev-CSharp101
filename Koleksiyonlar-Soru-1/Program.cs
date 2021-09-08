using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var asal = new ArrayList();
            var asalDegil = new ArrayList();
            int i = 0;
            int number;
            while (i < 20)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if (number >= 0 && IsPrime(number))
                    {
                        asal.Add(number);
                        i++;
                    }
                    else if (number >= 0)
                    {
                        asalDegil.Add(number);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen bir sayı giriniz");
                }
            }
            asal.Sort();
            asal.Reverse();
            asalDegil.Sort();
            asalDegil.Reverse();
            
            Console.Write($"Asal olanlar: ");
            foreach (var a in asal)
            {
                Console.Write(a + " | ");
            }
            Console.WriteLine($"Asal sayıların ortalaması: {Ort(asal)}");
            Console.Write($"Asal olmayanlar: ");
            foreach (var b in asalDegil)
            {
                Console.Write(b + " | ");
            }
            Console.WriteLine($"Asal olmayan sayıların ortalaması: {Ort(asalDegil)}");


        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
          
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
    
            return true;        
        }

        public static double Ort(ArrayList list)
        {
            int toplam = 0;
            foreach (int i in list)
            {
                toplam += i;
            }

            return toplam/list.Count;
        }
    }
}