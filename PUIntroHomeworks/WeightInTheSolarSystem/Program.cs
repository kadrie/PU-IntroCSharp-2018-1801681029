using System;

namespace WeightInTheSolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //napishete programa koqto izchislqva tegloto na chovek na vsqka edna ot planetite
            //tegloto se opredelq po formulata weightOnPlanet = gravitationalRatio*weight
            // където weight е собственото ви тегло а gravitationalRatio е константа за всяка планета
            // gravitationalRationalOnEarth=1

            //Venus=0.91 ; Mars=0.38 ; Jupiter=2.36 ; Saturn = 0.92 ; 

            double gravitationalRatio;
            double weigthOnPlanet;
       
            Console.WriteLine("Enter your weight on Earth.");
            byte weightOnEarth = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number corresponding to the planet so you can see how much you would weight there");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1 -> Venus ");
            Console.WriteLine("2 -> Mars");
            Console.WriteLine("3 -> Jupiter");
            Console.WriteLine("4 -> Saturn");
            Console.WriteLine("-------------------------------------------");

            byte option = byte.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    gravitationalRatio = 0.91;
                    weigthOnPlanet = gravitationalRatio * weightOnEarth;
                    Console.WriteLine($"Your weight on Venus will be {weigthOnPlanet}");
                        break;
                case 2:
                    gravitationalRatio = 0.38;
                    weigthOnPlanet = gravitationalRatio * weightOnEarth;
                    Console.WriteLine($"Your weight on Mars will be {weigthOnPlanet}");
                    break;
                case 3:
                    gravitationalRatio = 2.36;
                    weigthOnPlanet = gravitationalRatio * weightOnEarth;
                    Console.WriteLine($"Your weight on Jupiter will be {weigthOnPlanet}");
                    break;
                case 4:
                    gravitationalRatio = 0.92;
                    weigthOnPlanet = gravitationalRatio * weightOnEarth;
                    Console.WriteLine($"Your weight on Saturn will be {weigthOnPlanet}");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }


            

        }
    }
}
