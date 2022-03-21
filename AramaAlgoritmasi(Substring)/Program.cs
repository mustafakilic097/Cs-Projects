using System;

namespace AramaAlgoritmasi_Substring_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümleyi girin: ");
            string cumle = Console.ReadLine();

            string aranan = "";
            string subCumle = "";
            int x = 0;
            Console.Write("Aranacak Kelime: ");
            aranan = Console.ReadLine();
            for (int i = 0; i < cumle.Length; i++)
            {
                if (i >= (cumle.Length - aranan.Length))
                {
                    break;
                }
                subCumle = cumle.Substring(i, aranan.Length);
                if (subCumle == aranan)
                {
                    x++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Toplamda {0} tane '{1}' bulundu.\n", x, aranan);
            Console.ReadLine();


        }
    }
}
