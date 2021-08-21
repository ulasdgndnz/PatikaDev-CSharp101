using System;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Implicit conversions:
            No special syntax is required because the conversion always succeeds and no data will be lost.
            Examples include conversions from smaller to larger integral types, and conversions from derived classes to base classes.
            byte < short < int < float < double                                                                                        */
            
            sbyte a = 1;
            byte b = 6;
            short c = 52;
            ushort d = 300;

            int intToplam = a+b+c+d;

            uint x = 68;
            long y = 93;
            ulong z = 34;

            float floatToplam = intToplam + x + y;
            floatToplam += z;
            double doubleToplam = floatToplam;
            object toplam = doubleToplam;
            Console.WriteLine(toplam);

            // Explicit conversions

            //int to string
            int sayi1 = 51;
            Console.WriteLine(sayi1.ToString());

            //string to int
            string yazi1 = "65.3";
            Console.WriteLine(float.Parse(yazi1));

            // both
            string yazi2 = "99";
            int yeniSayi = Convert.ToInt32(yazi2);
            Console.WriteLine(yeniSayi);




            
        }
    }
}
