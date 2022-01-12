using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 1072;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Tunçer",1088,1);
            ogrenci1.SinifDüsür();
            ogrenci1.SinifDüsür();
            ogrenci1.OgrenciBilgileriniGetir();

        }
    }
    
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get { return isim;} set {isim = value;}}
        public string Soyisim { get { return isim;} set {isim = value;}}
        public int OgrenciNo { get { return isim;} set {isim = value;}}
        public int Sinif { 
            get { return isim;}
            set {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
                 else
                 {
                     sinif = value;
                 }

                }
            }
            
        public Ogrenci(string isim,string soyisim,int ogrenciNo,int sinif)
        {
           this.Isim = isim;
           this.Soyisim = soyisim;
           this.OgrenciNo = ogrenciNo;
           this.Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
             Console.WriteLine("****** Öğrenci Bilgileri ******");
             Console.WriteLine("Öğrenci Adi     :{0}",this.Isim);
             Console.WriteLine("Öğrenci Soyadi     :{0}",this.Soyisim);   
             Console.WriteLine("Öğrenci No     :{0}",this.OgrenciNo);
             Console.WriteLine("Öğrenci Sınıf     :{0}",this.Sinif);         
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDüsür()
        {
            this.Sinif = this.Sinif - 1;
        }

    }
}
