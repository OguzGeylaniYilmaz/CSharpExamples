using System;

namespace Metotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
                  
           int sonuc = Topla(3,5);
           Console.Write(sonuc);

           Metotlar ornek = new Metotlar();
           ornek.EkranaYazdir(Convert.ToInt32(sonuc));
       
           int sonuc2 = ornek.ArtirVeTopla(ref a,ref b);
           ornek.EkranaYazdir(Convert.ToInt32(sonuc2));
           ornek.EkranaYazdir(Convert.ToInt32(a,b));
            




        }

        static int Topla(ref int deger1,ref int deger2)
        {
            return deger1+deger1;
        }
    }

    class Metotlar
    {
       public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArtirVeTopla(int deger1,int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1+deger2;
        }
    }
}
