using System;

namespace Static_Sinif_Ve_Uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Çalışan Sayısı :{0}" , Calisan.CalisanSayisi);
          Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");
          Calisan calisan = new Calisan("Emre","Tunç","IT");
          Calisan calisan = new Calisan("Ahmet","Eren","Güvenlik");
          Console.WriteLine("Çalışan Sayısı :{0}" , Calisan.CalisanSayisi);

          Console.WriteLine("Toplama işlemi sonucu {0}",Islemler.Topla(40,73));
          Console.WriteLine("Çıkarma işlemi sonucu {0}",Islemler.Cikar(140,73));
        }
    }
    

    class Calisan
    {
       private static int calisanSayisi;
       private string Isim;
       private string Soyisim;
       private string Departman;

       public static int CalisanSayisi { get{return calisanSayisi;}}

       static Calisan()
       {
           calisanSayisi = 0;
       }
   

       public Calisan(string isim,string soyisim,string departman)
        {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;

        }
    }

    static class Islemler
    {
        public static long Topla(int x,int y)
        {
            return x + y;
        }

        public static long Cikar(int x,int y)
        {
            return x - y;
        }
    }
}