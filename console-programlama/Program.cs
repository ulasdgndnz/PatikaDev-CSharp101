using System;

namespace main_method
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("Yaşınızı Giriniz");
            string age = Console.ReadLine();
            Console.WriteLine(name + ", " + age);

            return 0;
        }
    }
}
