using System;

namespace Recursive_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Özyinelemeli
            //3^4 = 3*3*3*3

            int result = 1;
            for(int i=1;i<5;i++)
                result = result * 3;
            Console.WriteLine(result);

            Islemler ıslemler = new Islemler();
            Console.WriteLine(ıslemler.Expo(3,4));

            //Extensive  Metotlar

            string ifade = "Oğuz Yılmaz";
            bool sonuc = ifade.Checkspaces();
            Console.WriteLine(sonuc);
            if(sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] diziSırala = { 12,34,4,6,44,23,1 };
            diziSırala.SortArray();
            diziSırala.EkranaYazdir();

            int sonuc2 = 5;
            Console.WriteLine(sonuc2.isEven());
            Console.WriteLine(ifade.GetFirstCharacter());
            
           
        }
    }

    public class Islemler
    {
            public int Expo(int sayi,int us)
            {
                if(us<2)
                    return sayi;
                return Expo(sayi,us-1) * sayi;  
                //Expo(3,4)
                //Expo(3,3) * 3;
                //Expo(3,2) * 3 * 3;
                //Expo(3,1) * 3 * 3 * 3
                //3*3*3*3 = 3^4;         
            }
    }

    public static class Extension
    {
        public static bool Checkspaces(this string param)
        {
           return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
         public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach(int item in param)
            Console.WriteLine(item);
        }

        public static bool isEven(this int param)
        {
           return param% 2==0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    
    }
}