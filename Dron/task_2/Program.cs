using System;
using System.Linq;

internal class program
{
    public class Example
    {
        public static void Main()
        {
            int[] arr = { 8, 4, -2, 1, 10 };

            Console.WriteLine("Самое большое число - " + arr.Max());
            Console.WriteLine("Самое маленькое число - " + arr.Min());
        }
    }
}