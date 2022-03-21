using System;

namespace RandomSample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            double ortalama = 0;
            Random rnd = new Random();
            int[] sayilar = new int[20];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 100);
                toplam += sayilar[i];
            }
            ortalama = toplam / 20;
            Console.WriteLine("Ortalama: {0}", ortalama);
            Console.WriteLine();
            Console.WriteLine("Ortalamadan Küçük Olanlar");
            foreach (var item in sayilar)
            {
                if (item < ortalama)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ortalamadan Büyük Olanlar");
            foreach (var item in sayilar)
            {
                if (item > ortalama)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
