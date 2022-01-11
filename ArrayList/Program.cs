using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //Verilere erişim
            foreach (var item in liste)
                Console.WriteLine(item);

            //AddRange
            Console.WriteLine("**** Add Range ****");
            string[] renkler = new string[] { "kırmızı", "sarı", "yeşil" };
            List<int> sayılar = new List<int>() { 1, 2, 3, 4, 7, 5, 10 };
            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach(var x in liste)
                Console.WriteLine(x);

            //Sort
            Console.WriteLine("***** Sort *****");
            liste.Sort();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Binary Search
            Console.WriteLine("**** Binary Search ****");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("**** Reverse ****");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(liste);

            //Clear
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item); 

           }

        }
    }

   
