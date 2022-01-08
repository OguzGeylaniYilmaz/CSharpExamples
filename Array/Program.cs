using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi = {12,23,4,5,68,11,22};

            //Sırasız sayı dizisi
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort[sayiDizisi];

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("*** Array Clear ***");
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //Indexof
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 100;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

        }
    }
}