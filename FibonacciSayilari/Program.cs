using System;

namespace FibonacciSayilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PyramidMaker();
            Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("Girilen Değer Kadar Fibonacci Sayılarını Yazdırma");
            Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine();
            Console.Write("Kaç Adet Fibonacci Sayısı istiyorsunuz: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            double depoRef1 = 1;
            double depoRef2 = 1;
            double i = 1;
            double toplam = 1;
            int k = 2;
            string ayrac = "";

            double[] fibo = new double[(int)sayi];
            fibo[0] = 1;
            fibo[1] = 1;

            while (sayi != i)
            {

                if (i >= 2)
                {
                    toplam = depoRef1 + depoRef2;
                    if (toplam>0)
                    {
                        fibo[k] = toplam;
                        k++;
                    }
                }
                depoRef1 = depoRef2;
                depoRef2 = toplam;
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Fibonacci Sayıları({0} tane): ",sayi);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine();

            if (sayi>10)
            {
                Console.WriteLine("Çok fazla sayı bulundu");
                Console.Write("Sayıların arasında koymak istediğiniz ayracı yazın(Örn:,-): ");
                ayrac = Console.ReadLine();
                foreach (var item in fibo)
                {
                    Console.Write("{0}{1}", item, ayrac);
                }
            }
            else
            {
                foreach (var item in fibo)
                {
                    Console.Write("{0}{1}", item, ayrac=" ");
                }
            }
            Console.WriteLine();

            
            Console.WriteLine();
            Console.ReadLine();
        }


    }
}
