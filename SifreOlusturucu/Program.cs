using System;

namespace StringSample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kaç haneli olacak
            Console.WriteLine("Kaç haneli bir şifre oluşturulsun");
            int hane = Convert.ToInt32(Console.ReadLine());

            //Şifreyi tanımlama
            char[] sifre = new char[hane];

            //Kombinasyona girecek ifadeler
            string kucukHarfler = "abcçdefgğhıijklmnoöprsştvyz";
            string buyukHarfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
            string sayilar = "1234567890";
            string karakterler = "@*?.!-){_#$(";

            //Döngü içerisinde birden fazla kez şifreyi yazdırma seçeneği
            Random rnd = new Random();
            string islem = "";
            while (islem == "")
            {
                Console.Write("Yükleniyor: ");
                for (int i = 0; i < "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓".Length; i++)
                {
                    Console.Write("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓"[i]);
                    System.Threading.Thread.Sleep(20);
                }

                //Şifreyi rastgele indekselere rastgele ifadelerle yerleştirme
                int x = 0;
                while (x <= 300)
                {
                    sifre[rnd.Next(0, hane)] = kucukHarfler[rnd.Next(0, kucukHarfler.Length)];
                    sifre[rnd.Next(0, hane)] = sayilar[rnd.Next(0, sayilar.Length)];
                    sifre[rnd.Next(0, hane)] = buyukHarfler[rnd.Next(0, buyukHarfler.Length)];
                    sifre[rnd.Next(0, hane)] = sayilar[rnd.Next(0, sayilar.Length)];
                    sifre[rnd.Next(0, hane)] = karakterler[rnd.Next(0, karakterler.Length)];
                    sifre[rnd.Next(0, hane)] = kucukHarfler[rnd.Next(0, kucukHarfler.Length)];
                    sifre[rnd.Next(0, hane)] = buyukHarfler[rnd.Next(0, buyukHarfler.Length)];
                    sifre[rnd.Next(0, hane)] = karakterler[rnd.Next(0, karakterler.Length)];
                    x++;
                }

                //Şifreyi Yazdırma Bölümü
                Console.WriteLine();
                Console.WriteLine();
                foreach (var item in sifre)
                {
                    Console.Write(item);
                }
                Console.WriteLine("\n");
                Console.WriteLine("\n");

                //Tekrar eden 
                Console.WriteLine("Yeni bir şifre daha oluşturmak için 'ENTER'");
                islem = Console.ReadLine();
            }


        }
    }
}
