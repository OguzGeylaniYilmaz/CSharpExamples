using System;

namespace Donguler_Whie_Foreach
{
    class Program
     {
         static void Main(string[] args)
         {
             //While+
             // 1 den başlayarak console dan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp console a yazdıran program
             int sayi = int.Parse(Console.ReadLine());
             int sayac = 1;
             int toplam = 0;
             while(sayac<=sayi)
             {
                toplam += sayac;
                sayac++;
             }
             Console.Write("Ortalama=" + toplam/sayac);

             // a dan z'ye kadar tüm harfleri console a yazdır
            char character = 'a';
            while(character <='z')
            {
                Console.Write(character);
                character++;
            }

            //Foreach

            Console.WriteLine("**** Foreach ****");
            string[] arabalar = {"Audi","BMW","Alfa Romeo","Fiat"};
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
         }
     }
}