using System;
using System.Collections.Generic;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = new List<int>(){1, 2, 3 ,4 ,5 ,4, 3, 2, 1, 3, 4};
            var arr = new List<int>(){2, 4, 3, 2, 3, 1, 2, 1, 3, 3};
            arr.Sort();
            /*
            int max = 0;
            int counter = 0;
            // Tekrar etme sayısını bulma
            foreach (var a in arr)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (a == arr[i])
                    {
                        counter++;
                    }
                }
                if (counter> max)
                {
                    max = counter;
                }
                counter = 0;
                Console.Write(a + " | ");
            }

            Console.WriteLine();
            static int migratoryBirdsBulucu(List<int> liste, int max)
            {
                int answer = 0;
                Console.WriteLine("max : "+max);
                
                
                Console.WriteLine();
                for (int index = 0; index < liste.Count; index++)
                {
                    if (liste[index] == liste[index + (max-1)])
                    {
                        answer = liste[index];
                        break;
                    }
                }

                return answer;
            }
            
            Console.WriteLine(migratoryBirdsBulucu(arr, max));*/
            
            List<int> Id = new List<int>() {1,2,3,4,5 };
            int idNo = 0;
            int max = 0;
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + ".Tur ");
                foreach (int a in arr)
                {
                    Console.Write(a + " | ");
                    if (a == Id[i])
                    {
                        counter++;
                    }
                }
                Console.WriteLine();
                if (counter> max)
                {
                    max = counter;
                    idNo = i+1;
                }
                counter = 0;
            }
            Console.WriteLine();
            Console.WriteLine(idNo +" Id,  Adeti: "+ max);
        }
    }
}