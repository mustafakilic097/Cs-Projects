using System;

namespace ArmstrongSayilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*--*-*-*--*-*-*-*-*-*-");
            for (int i = 0; i < "|   Girilen İki Sayı Arasındaki ARMSTRONG sayılarını Bulma  |".Length; i++)
            {
                Console.Write("|   Girilen İki Sayı Arasındaki ARMSTRONG sayılarını Bulma  |"[index: i]);
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine();
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*--*-*-*--*-*-*-*-*-*-");
            Console.WriteLine();

            Console.WriteLine("Yükleniyor....");
            for (int i = 0; i < 50; i++)
            {
                Console.Write("▬");
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine();

            Console.Write("Başlangıç: ");
            int startNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş: ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string startString = Convert.ToString(startNumber);
            double depo = 0;
            int k = 0;
            int m = 0;


            while (startNumber <= endNumber)
            {
                startString = Convert.ToString(startNumber);
                for (int i = 0; i < startString.Length; i++)
                {
                    depo += Math.Pow(Convert.ToInt32(startString.Substring(i, 1)), startString.Length);
                }
                if (k == 0)
                {
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*--*-*-*--*-*-*-*-*-*-");
                    Console.WriteLine("Bulunan Armstrong Sayıları");
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*--*-*-*--*-*-*-*-*-*-");
                    Console.WriteLine();
                    k++;
                }

                if (depo == startNumber)
                {
                    Console.Write(depo + " ");
                    m++;
                }

                depo = 0;
                startNumber++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0} tane sayı bulundu... çıkış yapmak için: 'ENTER'", m);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
