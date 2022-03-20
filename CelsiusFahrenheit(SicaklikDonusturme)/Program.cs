using System;

namespace CelsiusFahrenheit_SicaklikDonusturme_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬Celsius, Fahrenheit, Kelvin Dönüştürme▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine();
            double celsius = 0;
            double fahrenheit = 0;
            double kelvin = 0;
            string devam = "e";


            while (devam=="e")
            {
                Console.Write("1-Celsius    --> Fahrenheit\n2-Fahrenheit --> Celsius\n3-Celsius    --> Kelvin\n4-Kelvin     --> Celsius\n\n\nSeçim: ");
                string islem = Console.ReadLine();
                Console.WriteLine();
                if (islem == "1")
                {
                    Console.Write("Celsius: ");
                    celsius = Convert.ToInt32(Console.ReadLine());

                    fahrenheit = celsius * 1.8 + 32;
                    Console.WriteLine("         {0} Celsius = {1} Fahrenheit", celsius, fahrenheit);
                    Console.WriteLine();
                }
                else if (islem == "2")
                {
                    Console.Write("Fahrenheit: ");
                    fahrenheit = Convert.ToInt32(Console.ReadLine());

                    celsius = (fahrenheit - 32) / 1.8;
                    Console.WriteLine("         {0} Fahrenheit = {1} Celsius", fahrenheit, celsius);
                    Console.WriteLine();
                }
                else if (islem == "3")
                {
                    Console.Write("Celsius: ");
                    celsius = Convert.ToInt32(Console.ReadLine());

                    kelvin = celsius + 273.15;
                    Console.WriteLine("         {0} Celsius = {1} Kelvin", celsius, kelvin);
                    Console.WriteLine();

                }
                else if (islem == "4")
                {
                    Console.Write("Kelvin: ");
                    kelvin = Convert.ToInt32(Console.ReadLine());

                    celsius = kelvin - 273.15;
                    Console.WriteLine("         {0} Kelvin = {1} Celsius", kelvin, celsius);
                    Console.WriteLine();
                }
                
                Console.WriteLine("Devam etmek istiyormusunuz(e/h): ");
                devam = Console.ReadLine();
            }

        }
    }
}
