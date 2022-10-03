using System;
using System.Linq;

namespace EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int j = 0; j < i ; j++)
                {
                    sumLeft += arr[j];
                }
                for(int j =  i + 1; j < arr.Length; j++)
                {
                    sumRight += arr[j];
                }
                if(sumLeft == sumRight)
                {
                    index = i;
                    break;
                }
            }

            if(index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
