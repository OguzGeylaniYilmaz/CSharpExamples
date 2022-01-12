using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Pazartesi);

            int sıcaklık = 32;

            if(sıcaklık <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
            else if(sıcaklık>=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if(sıcaklık>=(int)HavaDurumu && sıcaklık<(int)HavaDurumu.Çoksıcak)
                Console.WriteLine("Hadi dışarıya çekildi");
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soğuk ,
        Normal = 23,
        Sıcak = 34,
        Çoksıcak = 45
    }
}