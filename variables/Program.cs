using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bit = 5; // 0 to 255
            sbyte sbit = 5; //-128 to 127
            
            short kisa = 30000; //-32,768 to 32,767
            ushort ukisa = 60000; //0 to 65,535

            int sayi = 8; // -2,147,483,648 to 2,147,483,647
            uint usayi = 16; // 0 to 4,294,967,295

            long uzun = -22; // 
            ulong uuzun = 65; // 

            float f = 5.12f;
            double d = 6.5;
            decimal de = 22.9m;
            char ch = 'k';
            bool b = true;
            object o1 = 'Z';
            object o2 = true;
            string str = "Ulas";
            DateTime dt = DateTime.Now;

            // dönüşüm
            string str20 = "20";
            int int20 = 20;
            int yenideger = int20 + Convert.ToInt32(str20);

            string str40 = "40";
            int int40 = 40;
            string yenideger2 = str40 + int40.ToString();

            Console.WriteLine(yenideger + yenideger2);
        }
    }
}
