uusing System;

namespace Sinif_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
                //[Erişim Belirleyici] [Veri Tipi] [Özellik Adı];
                //[Erişim Belirleyici] [Geri Dönüş Tipi] [Parametre Listesi]
                //{ Metot Komutları}
            //}

            //Erişim Belirleyiciler
            //Public
            //Private
            //Internal
            //Protected


            Calisan calisan = new Calisan();
            calisan.Ad = "Oğuz";
            calisan.Soyad = "Yilmaz";
            calisan.No = 2313341412;
            calisan.Departman = "Bilgi-İşlem";

            calisan.CalisanBilgileri();

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Emre";
            calisan1.Soyad = "Demir";
            calisan1.No = 213234324;
            calisan1.Departman = "Güvenlik";

            calisan1.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.Write("Çalışanın {0}",Ad);
            Console.Write("Çalışanın {0}",Soyad);
            Console.Write("Çalışanın {0}",No);
            Console.Write("Çalışanın {0}",Departman);
        }
    }
}