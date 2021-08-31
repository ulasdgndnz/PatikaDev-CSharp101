using System;
using System.Collections.Generic;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var liste = new List<int>() {1, 6, 78, 2, 3, 5, 48, 3, 5, 6};
            Console.WriteLine(SumOfList(liste));

            var finder = new Finder();
            finder.FindOddEven(liste);
        }

        static int SumOfList(List<int> arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }

            return sum;
        }
    }

    class Finder
    {
        public void FindOddEven(List<int> arr)
        {
            var odd = 0; var even = 0;
            foreach (var i in arr)
            {
                if (i%2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("{0} Tek | {1} Çift",odd,even);
        }
    }
}