using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int pozitif = 0;
            int negatif = 0;
            int sifir = 0;
            Console.WriteLine("Kaç sayı hesaplamak istiyorsunuz?");
            int input = int.Parse(Console.ReadLine());
            
            int[] sayilar = new int[input];
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz", (i+1));
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach(var i in sayilar){
                if( i > 0 ){pozitif++;}
                else if( i < 0 ){negatif++;}
                else{sifir++;}
            }
            
            Console.WriteLine("Pozitif: {0}, Negatif: {1}, Sıfır: {2}", pozitif, negatif, sifir);
        }
    }
}