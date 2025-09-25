
using System;
internal class Program
{
    static void Main(string[] args)
    {
        int rows = 3;

        for (int i = 0; i < rows; i++)
        {
            int value = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(value + " ");

                value = value * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}
