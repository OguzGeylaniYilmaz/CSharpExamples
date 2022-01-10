using System;
using System.Collections;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/

            ArrayList array = new ArrayList();
           
            Console.WriteLine("Lütfen pozitif bir sayı giriniz");
            Console.Write("Girdiğiniz sayi: ");
            int n = int.Parse(Console.ReadLine());
            string kelime;
            Console.WriteLine("{0} adet kelime giriniz",n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. kelime = ",i+1);
                kelime = Console.ReadLine();
                array.Add(kelime);              
            }
            array.Reverse();
            foreach (var x in array)
                Console.WriteLine(x);
          
           
            Console.ReadLine();
        }
    }
}
