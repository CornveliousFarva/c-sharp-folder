using System;

namespace  PlanetCalculations
{
    class Program
    {
        static void Main(string[] args)

        {
            // My age
            int myAge = 33;

            // Length of a year on Jupiter in Earth years
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = myAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New age on Earth
            double newEarthAge = myAge + journeyToJupiter;

            //  New age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Console Logs for the above variables
            Console.WriteLine(jupiterAge);
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);
        }
    }
}