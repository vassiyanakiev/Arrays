using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size1];


            Console.WriteLine($"Enter {size1} element in array1:");
            for (int i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter array size: ");
            int size2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[size2];


            Console.WriteLine($"Enter {size2} element in array2:");
            for (int i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int mergeSize = size1 + size2;
            int[] mergeArray = new int[mergeSize];

            int index1 = 0;
            int index2 = 0;
            int merdgeIndex;

            for (merdgeIndex = 0; merdgeIndex < mergeSize; merdgeIndex++)
            {
                if (index1 >= size1 || index2 >= size2)
                {
                    break;
                }

                if (arr1[index1] < arr2[index2])
                {
                    mergeArray[merdgeIndex] = arr1[index1];
                    index1++;
                }
                else
                {
                    mergeArray[merdgeIndex] = arr2[index2];
                    index2++;
                }
              
            }
            
            while (index1 < size1)
            {
                mergeArray[merdgeIndex] = arr1[index1];
                merdgeIndex++;
                index1++;
            }
            while (index2 < size2)
            {
                mergeArray[merdgeIndex] = arr2[index2];
                merdgeIndex++;
                index2++;
            }

            Console.Write("\nArray merged in ascending order : ");
            for (int i = 0; i < mergeSize; i++)
            {
                Console.Write("{0}\t", mergeArray[i]);
            }
            Console.ReadLine();

        }
    }
}
