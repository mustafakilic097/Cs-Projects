using System;

namespace StringYerDegistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle = "Siz, benim nasıl yandığımı, nerden bileceksiniz.";
            int x = 0;
            char[] yeniCumle = new char[cumle.Length];
            for (int i = 0; i < cumle.Length; i++)
            {

                if (cumle[i] == '.')
                {
                    yeniCumle[x] = ',';
                    x++;
                }
                else if (cumle[i] == ',')
                {
                    yeniCumle[x] = '.';
                    x++;
                }
                else
                {
                    yeniCumle[x] = cumle[i];
                    x++;
                }
            }
            Console.WriteLine(yeniCumle);
        }
    }
}
