using System;

namespace PalindromikSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("İki Değer Arasındaki Palindromik Sayıları Bulma");
            Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.Write("Başlangıç: ");
            int ilkDeger = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş: ");
            int sonDeger = Convert.ToInt32(Console.ReadLine());
            int sayi = 0;
            int c = 0;

            while ((ilkDeger != sonDeger) && ilkDeger<sonDeger)
            {
                sayi = ilkDeger;
                ilkDeger++;
                int y = 0;

                //Basamak Hesaplama
                foreach (var z in Convert.ToString(sayi))
                {
                    y += 1;
                }


                //İlk yarı ve ikinci yarıyı ayırma
                string ilkYari = "";
                string ikinciYari = "";

                //Basamak sayısı çiftse
                if (y % 2 == 0)
                {
                    ilkYari = Convert.ToString(sayi).Substring(0, y / 2);

                    ikinciYari = Convert.ToString(sayi).Substring(y / 2, y / 2);
                }
                

                //Basamak sayısı tekse
                if (y % 2 == 1)
                {
                    ilkYari = Convert.ToString(sayi).Substring(0, (int)(y / 2));

                    ikinciYari = Convert.ToString(sayi).Substring((int)(y / 2) + 1, (int)(y / 2));
                }
                
                //İkinci Yarıyı ayırma ve ters çevirme
                char[] depo2 = new char[(int)(y / 2)];
                int m = 0;
                foreach (var item in ikinciYari)
                {
                    depo2[m] = item;
                    m++;
                }
                Array.Reverse(depo2);

                //Deponun karşılaştırmak için çevrilmesi
                string metin2 = new string(depo2);

                //Yazdırma
                if ((ilkYari == metin2) && y>1)
                {
                    if (c==0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                        Console.WriteLine("Bulunan Palindromik Sayılar");
                        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    c++;
                    Console.Write(sayi+" ");
                }
            }
            Console.ReadLine();
        }
    }
}
