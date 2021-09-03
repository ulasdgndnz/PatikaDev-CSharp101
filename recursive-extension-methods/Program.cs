using System;
using System.Linq;

namespace recursive_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            var expo = new Expo();
            
            Console.WriteLine(expo.UsAlma(a,b));
            Console.WriteLine(expo.Faktoriyel(b));

            string name = "Ulaş Doğan Deniz";
            string[] deneme = name.Split(" "); // >> {"Ulaş", "Doğan", "Deniz"}
            foreach (var i in deneme)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(string.Join("", deneme));
            
            if (name.CheckSpace())
            {
                Console.WriteLine(name.DeleteSpaces());
            }

            int[] numbers = {8, 2, 343, 8, 51, 4513, 6};
            numbers.LowSort().Print();
        }
    }

    class Expo
    {
        public int UsAlma(int sayi, int us)
        {
            if (us<2)
            {
                return sayi;
            }

            return UsAlma(sayi, us-1) * sayi;
        }
        // UsAlma(3, 4) * 3
        // UsAlma(3, 3) * 3 * 3
        // UsAlma(3, 2) *3 * 3 * 3
        // 3 * 3 * 3 * 3 * 3
        public int Faktoriyel(int sayi)
        {
            if (sayi<2)
            {
                return sayi;
            }
            
            return sayi * Faktoriyel(sayi-1);
        }
        // 5*4*3*2*1
    }

    public static class Extensions
    {
        public static bool CheckSpace(this string check)
        {
            return check.Contains(" ");
        }

        public static string DeleteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static int[] LowSort(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void Print(this int[] param)
        {
            foreach (var i in param)
            {
                Console.Write(i + " | ");
            }
        }
    }
}