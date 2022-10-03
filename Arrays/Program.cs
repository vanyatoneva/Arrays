using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int passengers = 0;
            for(int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                passengers += wagons[i];
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{wagons[i]} ");
            }
            Console.WriteLine();
            Console.Write(passengers);
        }
    }
}
