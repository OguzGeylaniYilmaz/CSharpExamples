using System;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("Lütfen 2 adet sayı giriniz");
            Console.Write("1.sayı=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("2.sayı=");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen {0} adet sayı giriniz", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayi = ", i + 1);
                int sayi = int.Parse(Console.ReadLine());
                if ((sayi == m) || (sayi % m == 0))
                    Console.WriteLine("{0} tam bölünüyor", sayi);
                else
                    Console.WriteLine("{0} {1} e eşit değil ya da tam bölünmüyor", sayi, m);

            }


            Console.ReadLine();
        }
    }
}
