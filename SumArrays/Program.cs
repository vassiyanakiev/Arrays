using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int sum = 0;

            Console.WriteLine($"Enter {size} elements in the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }

            Console.Write($"Sum of all elements of array = {sum}");
            Console.ReadLine();
        }
    }
}
