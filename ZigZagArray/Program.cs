﻿using System;
using System.Linq;
//using System.Collections;

namespace ZigZagArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for(int i = 0; i < n; i++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = line[0];
                    arr2[i] = line[1];
                }
                else
                {
                    arr2[i] = line[0];
                    arr1[i] = line[1];
                }
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
        }
    }
}
