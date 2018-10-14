using System;

namespace FourthDigitInNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number with 7 digits.");
            int sevenDigitNumber = int.Parse(Console.ReadLine());

            if (sevenDigitNumber < 1000000 || sevenDigitNumber > 9999999)
            {
                Console.WriteLine("The number you entered is not a 7-digit number!");
            }
            else
            {
                int fourthDigit = sevenDigitNumber % 1000000 % 100000 % 10000 / 1000;

                Console.WriteLine($"The 4th digit of {sevenDigitNumber} is {fourthDigit}");

            }
        }
    }
}
