using System;
using System.Linq;

namespace MaxSequenceOfEqualElem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().
                Select(int.Parse).
                ToArray();
            int maxSeq = 0;
            int firstIndex = 0;

            int i = 0;
            while(i < array.Length)
            {
                int thisSeq = 1;
                for (int j = i + 1  ; j < array.Length; j++)
                {
                    if (array[j] == array[j - 1])
                    {
                        thisSeq++;
                    }
                    else 
                    {
                        break;
                    }
                }
                if(thisSeq > maxSeq)
                {
                    maxSeq = thisSeq;
                    firstIndex = i;
                }
                i += thisSeq;
            }

            for(int k = 0; k < maxSeq; k++)
            {
                Console.Write($"{array[firstIndex]} ");
            }
        }
    }
}
