using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> users = new Dictionary<int,string>();

            users.Add(1,"Ali Çolak");
            users.Add(2,"Ahmet Tavlaşoğlu");
            users.Add(3,"Yunus Emre");
            users.Add(4,"İrem Kurnaz");

            //Dizinin elemanlarına erişim
            Console.WriteLine("**** Elemanlara erişim ****");
            Console.WriteLine(users[2]);
            foreach (var item in users)
                Console.WriteLine(item);

            //Count
            Console.WriteLine("**** Count ****");
            Console.WriteLine(users.Count);

            //Contains
            Console.WriteLine("*** Contains ***");
            Console.WriteLine(users.ContainsKey(1));
            Console.WriteLine(users.ContainsValue("Yunus Emre"));

            //Remove
            users.Remove(3);
           foreach (var item in users)
                Console.WriteLine(item.Value);

            //Keys
            Console.WriteLine("*** Keys ***");
            foreach (var item in users)
                Console.WriteLine(item.Key);
            
            //Values
            foreach(var item in users.Values)
                Console.WriteLine(item);

        }
    }
}