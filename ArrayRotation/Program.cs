using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            //string[] rotatedArr = new string[array.Length]; 
            for(int i = 0; i < n ; i++)
            {
                string dummy = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] =dummy;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
