using System;

namespace KomisyonHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double komisyon = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}. ürün fiyatı: ", i + 1);
                double urunFiyat = Convert.ToDouble(Console.ReadLine());

                if (urunFiyat <= 50)
                {
                    komisyon += (urunFiyat * 3 / 100);
                }
                else if (urunFiyat > 50)
                {
                    komisyon += (urunFiyat * 2 / 100);
                }
            }

            Console.WriteLine("Toplam Komisyon Tutarı: " + komisyon);
            Console.ReadLine();
        }
    }
}
