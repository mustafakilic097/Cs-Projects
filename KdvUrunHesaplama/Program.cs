using System;

namespace KdvUrunHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ürün fiyatı: ");
            double urunFiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kdv yüzdesi (Örn:18): ");
            double urunKdv = Convert.ToDouble(Console.ReadLine()) / 100;

            double tutar = urunFiyat + urunFiyat * urunKdv;

            Console.WriteLine("\nÜrün Satış Fiyatı: " + tutar);


        }
    }
}
