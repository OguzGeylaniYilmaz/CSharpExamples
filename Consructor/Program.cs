using System;

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



            Console.WriteLine("****** Çalışan 1*******");
            Calisan calisan = new Calisan("Ayşe","Kara",123123213,"İnsan Kaynakları");
            calisan.CalisanBilgileri();

            Console.WriteLine("****** Çalışan 2*******");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Emre";
            calisan2.Soyad = "Demir";
            calisan2.No = 213234324;
            calisan2.Departman = "Güvenlik";
            calisan2.CalisanBilgileri();
           
           Console.WriteLine("****** Çalışan 3*******");
           Calisan calisan3 = new Calisan();
           calisan3.CalisanBilgileri("Semra","Tunç");

            
        }
    }

    class Calisan
    {

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad= ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad ,string soyad) 
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan() {}
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