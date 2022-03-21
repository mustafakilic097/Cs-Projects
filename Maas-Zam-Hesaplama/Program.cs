using System;

namespace HisseDeger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ MAAŞ ZAM HESAPLAMA ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine();
            Console.Write("Maaş: ");
            double maas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zam yüzdesi: ");
            double zam = maas * Convert.ToInt32(Console.ReadLine()) / 100;


            Console.WriteLine();
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ Maaş: {0} Zam: {1} ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒", maas, zam);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ Toplam Maaş: {0}    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒", maas + zam);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
