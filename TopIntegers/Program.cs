using System;
using System.Linq;

namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().
                Select(int.Parse).
                ToArray();
            bool isTopInt = true;
            for(int i = 0; i < array.Length; i++)
            {
                isTopInt = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    
                    if (array[j] >= array[i])
                    {
                        isTopInt = false;
                        break;
                    }
                    
                }
                if (isTopInt)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            //Console.Write(array[array.Length - 1]);
        }
    }
}
