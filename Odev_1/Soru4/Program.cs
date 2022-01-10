using System;
using System.Collections;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/

            string cumle = null;
            int toplamharf = 0;
            Console.WriteLine("Lütfen bir cümle yazınız");           
            cumle = Console.ReadLine();
            Console.Write("Girdiğiniz cümle = " + cumle);
            string[] kelimeSayisi = cumle.Split(' ');
            char[] toplamHarfSayisi = cumle.ToCharArray();
            
            Console.WriteLine();
            Console.WriteLine("Kelime sayısı : " + kelimeSayisi.Length);

          
            foreach (var item in toplamHarfSayisi)
            {
                if (item == ' ')
                    continue;
                toplamharf++;
            }
            Console.Write("Toplam harf sayisi = " + toplamharf);

            Console.ReadLine();
        }
    }
}
