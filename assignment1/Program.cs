using System;
using System.Collections.Generic;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string giris = "";
            while (giris != "q")
            {
                Console.WriteLine("Çıkmak için q basın");
                giris = Console.ReadLine();
                Console.WriteLine("1-4 Arası Bir sayı Giriniz");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1 Seçildi");
                        Console.WriteLine("Pozitif bir tamsayı giriniz");
                        int n1 = int.Parse(Console.ReadLine());
                        List<int> numbers1 = new List<int>(n1);
                        Console.WriteLine($"{n1} adet tamsayı giriniz");
                        for (int i = 0; i < n1; i++)
                        {
                            int input = int.Parse(Console.ReadLine());
                            numbers1.Add(input);
                        }
                        numbers1.PrintDivide(2);
                        break;
                    case 2:
                        Console.WriteLine("2 Seçildi");
                        Console.WriteLine("Pozitif iki tamsayı giriniz");
                        int n2 = int.Parse(Console.ReadLine());
                        int m2 = int.Parse(Console.ReadLine());
                        List<int> numbers2 = new List<int>(n2);
                        Console.WriteLine("{0} adet tamsayı giriniz", n2);
                        for (int i = 0; i < n2; i++)
                        {
                            int input = int.Parse(Console.ReadLine());
                            numbers2.Add(input);
                        }
                        numbers2.PrintDivide(m2);
                        break;
                    case 3:
                        Console.WriteLine("3 Seçildi");
                        Console.WriteLine("Pozitif bir tamsayı giriniz");
                        int n3 = int.Parse(Console.ReadLine());
                        List<string> words = new List<string>(n3);
                        Console.WriteLine("{0} adet kelime giriniz", n3);
                        for (int i = 0; i < n3; i++)
                        {
                            string input = Console.ReadLine();
                            words.Add(input);
                        }
                        words.Printer(false);
                        break;
                    case 4:
                        Console.WriteLine("4 Seçildi");
                        Console.WriteLine("Bir cümle giriniz");
                        string sentence = Console.ReadLine();
                        sentence.FindLetterWord();
                        break;
                    default:
                        Console.WriteLine("Lütfen 1-4 arası bir seçim yapınız");
                        break;
                }
            }
            
        }
    }

    public static class Extensions
    {
        public static void PrintDivide(this List<int> arr, int n)
        {
            Console.Write($"{n}'a bölünebilen tam sayılar: ");
            foreach (var i in arr)
            {
                if (i%n == 0)
                {
                    Console.Write(i + " | ");
                }
            }
        }

        public static void Printer(this List<string> arr, bool param)
        {
            if (param)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    Console.Write(arr[i] + " | ");
                }
            }

            if (param == false)
            {
                for (int i = arr.Count - 1; i >= 0; i--)
                {
                    Console.Write(arr[i] + " | ");
                }
            }
        }
        public static void Printer(this string[] arr, bool param)
        {
            if (param)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " | ");
                }
            }

            if (param == false)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.Write(arr[i] + " | ");
                }
            }
        }
        public static void FindLetterWord(this string param)
        {
            string[] dizi = param.Split(" ");
            int word = dizi.Length;
            
            string letter = string.Join("", dizi);
            char[] characters = letter.ToCharArray();
            int let = characters.Length;
            
            Console.WriteLine($"{let} letter | {word} word");
        }
    } 
}