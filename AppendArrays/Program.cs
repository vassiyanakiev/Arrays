using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
               .Split('|', StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            List<string> result = new List<string>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] elements = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                result.AddRange(elements);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
