using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];


            Console.WriteLine($"Enter {size} element in array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array in reverse: ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.ReadLine();
        }
    }
}
