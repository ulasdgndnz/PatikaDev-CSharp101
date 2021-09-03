using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int toplam;
            calculator.Topla(a, b, out toplam);
            Console.WriteLine(toplam);
            
            int x = int.Parse(Console.ReadLine());
            string y = Console.ReadLine();
            int yaz;
            calculator.Topla(x,y, out yaz);
            Console.WriteLine(yaz);

            int deneme;
            int n = 7;
            calculator.SampleMethod(out deneme);
            Console.WriteLine(deneme+n);
        }
    }

    class Calculator
    {
        public void Topla(int s1, int s2, out int cevap)
        {
            cevap = s1 + s2;
        }
        public void Topla(int s1, string s2, out int cevap)
        {
            cevap = s1 + int.Parse(s2);
        }
        
        public void SampleMethod(out int i) => i = 5;
    }
}