using System;

namespace HipotenusHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("▒▒▒▒▒▒Hipotenüs Hesaplama▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            string islem = "";
            while (islem=="")
            {
                Console.Write("\n1.Kenar: ");
                int kenar1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Kenar: ");
                int kenar2 = Convert.ToInt32(Console.ReadLine());

                double hipotenus = Math.Sqrt((kenar1 * kenar1 + kenar2 * kenar2));

                Console.WriteLine("\n\nHesaplanan Hipotenus: {0}", hipotenus);


                Console.WriteLine("\n\nDevam etmek için 'ENTER' basın.");
                islem = Console.ReadLine();
            }
            
        }
    }
}
