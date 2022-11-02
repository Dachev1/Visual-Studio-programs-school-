using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangementOfNumbers
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int arraySize = 5;
            int[] array = new int[5] { 64, 25, 12, 22, 11 };
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}