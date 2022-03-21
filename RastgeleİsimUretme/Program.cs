using System;

namespace RastgeleİsimUretme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dosyayolu1 = System.IO.File.ReadAllText(@"C:/Users/Mustafa-Lenovo/Desktop/C#/RastgeleİsimUretme/isimler.txt");
            string dosyayolu2 = System.IO.File.ReadAllText(@"C:/Users/Mustafa-Lenovo/Desktop/C#/RastgeleİsimUretme/soyadlar.txt");
            Random rnd = new Random();

            

            bool deger = true;
            string devam = "e";
            while (deger==true || devam=="e")
            {
                string isim = dosyayolu1.Split()[rnd.Next(0, dosyayolu1.Split().Length)];
                string soyad = dosyayolu2.Split()[rnd.Next(0, dosyayolu2.Split().Length)];
                if (isim.Length >= 3 && soyad.Length >= 3)
                {
                    Console.WriteLine(isim + " " + soyad);
                    deger = false;
                    Console.WriteLine("devam etmek istiyormusunuz(e/h): ");
                    devam = Console.ReadLine();
                }
            }



        }
    }
}
