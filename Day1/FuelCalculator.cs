﻿using System;

namespace Day1
{
    public class FuelCalculator
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            int totalFuel = 0;
            foreach(string line in lines)
            {
                int mass = System.Convert.ToInt32(line);
                totalFuel += ComputeFuel(mass);
            }
            Console.WriteLine($"Total fuel: {totalFuel}");
            Console.Read();
        }

        /// <summary>
        /// Recursively calculates the fuel required for a payload.
        /// </summary>
        /// <param name="payloadMass">The payload mass in "units"</param>
        /// <returns>The fuel required for the payload mass.</returns>
        public static int ComputeFuel(int payloadMass)
        {
            Console.WriteLine($"Computing mass of: {payloadMass}");
            int fuelForPayload = (int)(payloadMass / 3);
            fuelForPayload -= 2;
            if (fuelForPayload <= 0)
            {
                return 0;
            }
            int fuelForFuel = ComputeFuel(fuelForPayload);
            return fuelForPayload + fuelForFuel;
        }
    }
}
