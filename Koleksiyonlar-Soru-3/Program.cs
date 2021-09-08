using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = Console.ReadLine();
            char[] sesliHarfler = new char[]{'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            List<char> sesliler = new List<char>();
            foreach (char c in sesliHarfler)
            {
                if (cumle.Contains(c))
                {
                    sesliler.Add(c);
                }
            }
            sesliler.ForEach(sesli => Console.Write( sesli + " | "));

        }
    }
}