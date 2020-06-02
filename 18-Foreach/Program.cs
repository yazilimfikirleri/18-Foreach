using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Foreach Döngüsü
            //Koleksiyon yapılarında kullanılan bir döngü çeşitidir. Dizi ve List gibi yapılarda kullanılır. Foreach döngüsüne müdehale edilemez. İterasyon bulunmamaktadır.

            //string[] ogrenciler = { "Ali", "Ayşe", "Mehmet", "Zeynep" };
            //foreach(string ogrenci in ogrenciler)
            //{
            //    Console.WriteLine(ogrenci);
            //}
            //Console.Read();

            //123,54,76,876,4532,23,77,83,45,190
            //yukarıdaki sayılardan ikiye tam bölünenlerin adetini ve bölünmeyenlerin adetini console ekranında gösterin.

            int[] sayilar = { 123, 54, 76, 876, 4532, 23, 77, 83, 45, 190 };

            int ikiyeTamBolunenler = 0;
            int tamBolunmeyenler = 0;

            foreach(int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    ikiyeTamBolunenler++;
                }
                else
                {
                    tamBolunmeyenler++;
                }
            }
            Console.WriteLine($"ikiye tam bölünenler= {ikiyeTamBolunenler}");
            Console.WriteLine($"ikiye tam bölünmeyenler= {tamBolunmeyenler}");

            Console.Read();


        }
    }
}
