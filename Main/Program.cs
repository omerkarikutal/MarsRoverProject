using Main.Models;
using System;
using Core.Enums;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Location baseLocation = new Location(5, 5);

            //İlk test
            Rover rover1 = new Rover(new Location(1, 2), Directions.N, baseLocation);
            var rover1Result = rover1.StartCalculateLocation("LMLMLMLMM");
            Console.WriteLine($"İlk Test Sonuç : {rover1Result.Message}");

            //İkinci test
            Rover rover2 = new Rover(new Location(3, 3), Directions.E, baseLocation);
            var rover2Result = rover2.StartCalculateLocation("MMRMMRMRRM");
            Console.WriteLine($"İkinci Test Sonuç : {rover2Result.Message}");


            //Üçüncü test hata mesajı dönen
            Rover rover3 = new Rover(new Location(4, 4), Directions.N, baseLocation);
            var rover3Result = rover2.StartCalculateLocation("MM");
            Console.WriteLine($"Üçüncü Test Sonuç : {rover3Result.Message}");


            Console.ReadLine();
        }
    }
}
