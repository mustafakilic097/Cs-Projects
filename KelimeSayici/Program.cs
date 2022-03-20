using System;

namespace KelimeSayici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("▬▬▬▬▬▬▬▬▬▬▬▬Kelime Sayacı▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine();

            Console.Write("Cümle: ");
            string cumle = Console.ReadLine();
            Console.WriteLine();
            int sayac = 1;
            char[] harfler = { 'A', 'a', 'B', 'b', 'C', 'c', 'Ç', 'ç', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'ı', 'İ', 'i', 'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o', 'Ö', 'ö', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'Ş', 'ş', 'T', 't', 'U', 'u', 'Ü', 'ü', 'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z', 'z', '.', ',', '!', '?', ':', ';' };
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == ' ')
                {
                    sayac++;
                }
            }
            Console.WriteLine("\nSayılan kelime: {0}", sayac);

        }
    }
}
