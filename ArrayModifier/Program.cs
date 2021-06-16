using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command
                    .Split();

                int index1 = 0;
                int index2 = 0;
                switch (tokens[0])
                {
                    case "swap":
                        index1 = int.Parse(tokens[1]);
                        index2 = int.Parse(tokens[2]);
                        int tempNumber = numbers[index1];
                        numbers[index1] = numbers[index2];
                        numbers[index2] = tempNumber;
                        break;
                    case "multiply":
                        index1 = int.Parse(tokens[1]);
                        index2 = int.Parse(tokens[2]);
                        numbers[index1] *= numbers[index2];
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]--;
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
for (int i = 0; i < numbersArray.Length - count; i++)
{
    subArray3[i] = numbersArray[count + i];

}

numbersArray = subArray3;
