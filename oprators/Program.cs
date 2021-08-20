using System;

namespace oprators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 6;

            int toplam = 0;
            toplam+= x;
            toplam+= y;
            Console.WriteLine(toplam);

            toplam*= 10; 
            Console.WriteLine(toplam);

            ////////////////////////////
            
            bool isSuccess = true;
            bool isFail = false;
            if ( toplam % 10 == 0 || isSuccess )
            {
                Console.WriteLine("Perfect");
            }

            if ( toplam % 10 != 0 && isFail )
            {
                Console.WriteLine("Great");
            }            

            ////////////////////////////
            int a = 2;
            int b = 4;
            bool trueOrFalse = 4<2;
            if (false == trueOrFalse)
            {
                Console.WriteLine("False");
            }

            if (true == trueOrFalse)
            {
                Console.WriteLine("True");
            }
        }
    }
}
