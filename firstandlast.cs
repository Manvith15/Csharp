using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a num:");
        int num = Convert.ToInt32(Console.ReadLine());
        int lastDigit = num % 10;
        int firstDigit = num;
        while (firstDigit >= 10)
        {
            firstDigit /= 10;
        }
        Console.WriteLine("First digit:" + firstDigit);
        Console.WriteLine("Last digit:" + lastDigit);
    }
    }