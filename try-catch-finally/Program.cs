using System;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());

                int b = int.Parse(Console.ReadLine());

                int c = a+b;

                int d = int.Parse(null);

                Console.WriteLine(c);
            }

            catch(ArgumentNullException) // boş girilirse
            {
                Console.WriteLine("Lütfen bir değer girerek tekrar deneyiniz");
            }
            catch(FormatException) //sayı girilirse
            {
                Console.WriteLine("Lütfen bir sayı1 girerek tekrar deneyiniz");
            }
            catch(Exception ex) 
            {
                if (ex.GetHashCode() == 58225482) // sayı girilirse 2
                {
                    Console.WriteLine("Lütfen bir sayı2 girerek tekrar deneyiniz");
                }
                else
                {
                    Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);
                }
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }       

        }
    }
}
