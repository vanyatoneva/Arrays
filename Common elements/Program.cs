using System;

namespace Common_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strArr1 = Console.ReadLine();
            string strArr2 = Console.ReadLine();
            string[] arr1 = strArr1.Split();
            string[] arr2 = strArr2.Split();
            int n;
            
            if(arr1.Length > arr2.Length)
            {
                n = arr2.Length;
            }
            else
            {
                n = arr1.Length;
            }

            string[] commons = new string[n];
            int k = 0;
            for(int i = 0; i < arr2.Length; i++)
            {
                for(int j = 0; j < arr1.Length; j++)
                {
                    if(string.Compare(arr2[i], arr1[j]) == 0)
                    {
                        commons[k] = arr2[i];
                        k++;
                    }
                }
            }

            for(int i = 0; i < k; i++)
            {
                Console.Write($"{commons[i]} ");
            }
        }
    }
}
