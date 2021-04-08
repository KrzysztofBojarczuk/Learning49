using System;

namespace Koszt_wysyłki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wagę przesyłki:");
            double weight = double.Parse(Console.ReadLine());


            if (weight < 2)
            {
                Console.WriteLine("Koszt wysyłki będzie wynosił 5,10 zł.");
            }
            else if (weight > 2 && weight < 6)
            {
                Console.WriteLine("Koszt wysyłki będzie wynosił 6,20 zł.");
            }
            else if (weight > 6 && weight < 10)
            {
                Console.WriteLine("Koszt wysyłki będzie wynosił 7,70 zł.");
            }
            else if (weight > 10)
            {
                Console.WriteLine("Koszt wysyłki bedzie wynosił 8,10 zł.");
            }
        }
    }
}
