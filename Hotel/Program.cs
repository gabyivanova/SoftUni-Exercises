using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPricePerNight = 0;
            double doublePricePerNight = 0;
            double suitePricePerNight = 0;
            double totalPriceStudio = 0;
            double totalPriceDouble = 0;
            double totalPriceSuite = 0;

            if (month == "May" || month == "October")
            {
                studioPricePerNight = 50;
                doublePricePerNight = 65;
                suitePricePerNight = 75;

                totalPriceStudio = nights * studioPricePerNight;
                totalPriceDouble = nights * doublePricePerNight;
                totalPriceSuite = nights * suitePricePerNight;

                if (nights > 7)
                {
                    totalPriceStudio = (nights * studioPricePerNight) * 0.95;

                    if (month == "October")
                    {
                        totalPriceStudio = ((nights - 1) * studioPricePerNight) * 0.95;
                    }
                }

                Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
                Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
                Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");
            }

            else if (month == "June" || month == "September")
            {
                studioPricePerNight = 60;
                doublePricePerNight = 72;
                suitePricePerNight = 82;

                totalPriceStudio = nights * studioPricePerNight;
                totalPriceDouble = nights * doublePricePerNight;
                totalPriceSuite = nights * suitePricePerNight;

                if (nights > 14)
                {
                    totalPriceDouble = (nights * doublePricePerNight) * 0.90;
                }

                if (month == "September" && (nights > 7 && nights < 14))
                {
                    totalPriceStudio = ((nights - 1) * studioPricePerNight);
                }

                Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
                Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
                Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");
            }

            else if (month == "July" || month == "August" || month == "December")
            {
                studioPricePerNight = 68;
                doublePricePerNight = 77;
                suitePricePerNight = 89;

                totalPriceStudio = nights * studioPricePerNight;
                totalPriceDouble = nights * doublePricePerNight;
                totalPriceSuite = nights * suitePricePerNight;

                if (nights > 14)
                {
                    totalPriceSuite = (nights * suitePricePerNight) * 0.85;
                }

                Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
                Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
                Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");
            }
        }
    }
}
