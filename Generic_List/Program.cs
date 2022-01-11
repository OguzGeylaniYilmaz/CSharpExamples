using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.Write(renkListesi.Count);
            Console.Write(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);
            
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Liste içerisinde arama

            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu");
            
            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Diziyi liste çevirme
            string[] animals = {"Kedi","Köpek","Kuş",""};
            List<string> animalList = new List<string>(animals);

            //Listeyi temizleme
            animalList.Clear();

            //List içeriside nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Isim = "Oğuz";
            kullanici.Soyisim = "Yılmaz";
            kullanici.Yas = 27;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "İlknur";
            kullanici2.Soyisim = "Eren";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar
            {
                Isim =  "Emre",
                Soyisim = "Bahar",
                Yas = 20
            });

            foreach (var item in yeniListe)
            {
                Console.WriteLine("Kullanıcı Adı : " + item.Isim);
                Console.WriteLine("Kullanıcı Soyadı : " + item.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı : " + item.Yas);
            }
            
            yeniListe.Clear();
     
        }
   
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim;set=>isim=value;}
        public string Soyisim { get => soyisim;set=>soyisim=value;}
        public string Yas { get => yas;set=>yas=value;}
    }
}