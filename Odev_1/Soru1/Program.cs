
using System;

namespace Soru_1
{ 
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen pozitif bir sayı giriniz = ");
            int n = int.Parse(Console.ReadLine());

            if (n>0)
            {
                Console.WriteLine("Lütfen {0} adet sayı giriniz",n);
                for (int i = 1; i < n; i++)
                {
                    Console.WriteLine("{0}. sayı = " , i);
                    int sayi = int.Parse(Console.ReadLine());
                    if(sayi %2 == 0)
                        Console.WriteLine("Sayı çiftdir = " ,sayi);
                    else
                        Console.WriteLine("Sayı tektir = ",sayi);
                }

            }

            Console.ReadLine();
        }


    }
}
  