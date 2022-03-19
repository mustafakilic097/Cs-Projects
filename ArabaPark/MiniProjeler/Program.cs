using System;

namespace MiniProjeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Araç çeşitleri\n____(taksi: t)\n____(minibus: m)\n____(ticariarac: ta)\n\nAraç Türü: ");
            string aracTuru = Console.ReadLine();

            Console.Write("\nKaç dakika durdu: ");
            double gecenVakit = Convert.ToInt32(Console.ReadLine());

            if (aracTuru == "t")
            {
                if (gecenVakit >= 120)
                {
                    double extraTutar = (Convert.ToInt32(gecenVakit) / 60) * 5 * 20 / 100;
                    double tutar = Math.Round(((gecenVakit / 60) * 5), 2) + extraTutar - 1;
                    Console.WriteLine("Ödenecek Tutar: {0}", tutar);
                }
                else
                {
                    double tutar = Math.Round(((gecenVakit / 60) * 5), 2);
                    Console.WriteLine("Ödenecek Tutar: {0}", tutar);
                }
            }
            else if (aracTuru == "m")
            {
                if (gecenVakit >= 120)
                {

                    double extraTutar = (Convert.ToInt32(gecenVakit) / 60) * 6 * 21.5 / 100;
                    double tutar = Math.Round(((gecenVakit / 60) * 6), 2) + extraTutar - 1.29;
                    Console.WriteLine("Ödenecek Tutar: {0}", tutar);
                }
                else
                {
                    double tutar = Math.Round(((gecenVakit / 60) * 6), 2);
                    Console.WriteLine("Ödenecek Tutar: {0}", tutar);
                }
            }
            else if (aracTuru == "ta")
            {
                if (gecenVakit >= 120)
                {

                    double extraTutar = (Convert.ToInt32(gecenVakit) / 60) * 6.5 * 25 / 100;
                    double tutar = Math.Round(((gecenVakit / 60) * 6.5), 2) + extraTutar - 1.625;
                    Console.WriteLine("Ödenecek Tutar: {0}", tutar);
                }
                else
                {
                    double tutar = Math.Round(((gecenVakit / 60) * 6.5), 2);
                    Console.WriteLine("Ödenecek Tutar: {0}", tutar);
                }
            }
            else
            {
                Console.WriteLine("Hatalı giriş tespit edildi!!");
            }



            /*
                Örnek 4: Bir otoparka park eden taksinin 1 saati 5TL, 
                minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. 
                Taksi 1 saatten sonraki her saat başı için % 20 daha fazla, 
                minibüs 1 saatten sonraki her saat başı için toplamda % 21.5 ve 
                ticari araç 1 saatten sonraki her saat başı için toplamda % 25 daha 
                fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan 
                saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan 
                programın kodlarını yazınız.
            */
        }
    }
}
