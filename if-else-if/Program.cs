using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now.Hour;

            string  HaberVer(double saat) => saat < 12 ? "12 den sonra" : "12 den önce";

            Console.WriteLine(HaberVer(time) + " " + time);
        }
    }
}
