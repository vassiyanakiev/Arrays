using System;
using System.Linq;
namespace Zig_ZagArrays
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] arr1 = new int[size];

            int[] arr2 = new int[size];

            for (int i = 0; i < size; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = numbers[0];
                int secondNumber = numbers[1];

                if (i % 2 != 0)
                {
                    arr1[i] = secondNumber;
                    arr2[i] = firstNumber;
                }
                else
                {
                    arr1[i] = firstNumber;
                    arr2[i] = secondNumber;
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
