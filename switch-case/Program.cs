using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int second = DateTime.Now.Second;

            switch (second)
            {
                case < 10:
                    Console.WriteLine("Saniye 1-10 arasında");
                    break;
                
                case < 20:
                    Console.WriteLine("Saniye 11-20 arasında");
                    break;
                
                case < 30:
                    Console.WriteLine("Saniye 21-30 arasında");
                    break;
                case < 40:
                    Console.WriteLine("Saniye 31-40 arasında");
                    break;
                case < 50:
                    Console.WriteLine("Saniye 41-50 arasında");
                    break;
                case <= 60:
                    Console.WriteLine("Saniye 51-60 arasında");
                    break;

                default:
                    Console.WriteLine("Saniye 1-10 arasında");
                    break;
            }
        }
    }
}
