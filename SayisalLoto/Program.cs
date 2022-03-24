using System;

namespace SayisalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random randomObject = new Random();
            int[] randomNumbers = new int[6];
            bool control = true;

            int i = 0;
            while (true)
            {
                //Üretim Bölgesi
                int randomNumber = randomObject.Next(0, 91);

                //Kontrol Bölgesi
                foreach (int number in randomNumbers)
                {
                    if(number == randomNumber)
                    {
                        control = false;
                    }
                }

                //Ekleme Bölgesi
                if (control)
                {
                    randomNumbers[i] = randomNumber;
                    i++;
                }
                else
                {
                    control = true;
                    continue;
                }
                
                //Durdurma Bölgesi
                if(i == 6)
                {
                    break;
                }
                else
                {
                    control = true;
                    continue;
                }
            }


            //Normal Yazdırma Bölgesi
            int x = 1;
            foreach (var item in randomNumbers)
            {
                Console.WriteLine("__________");
                Console.WriteLine(x + ".Sayı: " + item);
                Console.WriteLine("__________");
                x++;
            }
            


            //Animasyonlu Yazdırma Bölgesi
            /*
            Console.WriteLine("__________");
            int y = 1;
            foreach (var item in randomNumbers)
            {
                string anime = y + ".Sayı: ";
                string stringIt = Convert.ToString(item);
                foreach (var an in anime)
                {
                    System.Threading.Thread.Sleep(75);
                    Console.Write(an);
                }
                System.Threading.Thread.Sleep(300);
                foreach (var it in stringIt)
                {
                    System.Threading.Thread.Sleep(400);
                    Console.Write(it);
                    System.Threading.Thread.Sleep(400);
                }
                Console.WriteLine();
                Console.WriteLine("__________");
                y++;
            }
            Console.ReadLine();
            */
            Console.ReadLine();
        }
    }
}
