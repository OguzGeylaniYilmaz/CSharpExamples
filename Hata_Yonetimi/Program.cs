using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
            }
            catch(Exception ex)
            {
                WriteLine("Hata:" + ex.Message.ToString());
            }
            //
            //finally
            //{
            //    Console.WriteLine("İşlem tamamlandı");
             //}
            
            try
            {
                int a = int.Parse(null);
                int a1 = int.Parse("-2000000000000");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri Tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
               Console.WriteLine("İşlem tamamlandı");
            }
        }
    }
}