using System;

namespace SiralamaAlgoritması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("▬▬▬▬▬Bubble Sort▬▬▬▬▬Kabarcık Sıralaması▬▬▬▬▬");
            Console.WriteLine();
            //Dizi tanımlanması
            int[] dizi = {5,4,2,1,6,9,12,7};
            int kucuk = dizi[0];

            //İç içe döngü ile elemanları dönme
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j++)
                {
                    //elemanlardan kucuk olanı ile büyük olanının yerini değiştirme.
                    //Bubble Sort -> Kabarcık Sıralaması
                    if (dizi[j]>dizi[i])
                    {
                        kucuk = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = kucuk;
                    }
                }
            }

            //Diziyi yazdırma
            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0} tane eleman başarıyla sıralandı...", dizi.Length);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
