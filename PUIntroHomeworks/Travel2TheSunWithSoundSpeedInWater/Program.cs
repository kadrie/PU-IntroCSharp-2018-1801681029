using System;

namespace Travel2TheSunWithSoundSpeedInWater
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int distance2SunFromEarth = 149600000;
            short speedOfSoundIn20DegreeWater = 1481;
            double timeNeeded = (double) distance2SunFromEarth / speedOfSoundIn20DegreeWater;
            double timeNeededInYears = Math.Floor(timeNeeded / 8760);
            double timeNeededInDays = Math.Floor(timeNeeded / 24);

            Console.WriteLine($"The time needed to travel from Earth to the Sun is: " +
                $" {timeNeeded} hours, or {timeNeededInYears} years, or {timeNeededInDays} days.");
            
        }
    }
}
