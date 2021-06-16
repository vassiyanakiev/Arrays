﻿using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if (command == "exchange")
                {
                    int index = int.Parse(parts[1]);
                    Exchange(numbers, index);
                }
                else if (command == "max")
                {
                    string parameter = parts[1];

                    int index = GetMax(numbers, parameter);

                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (command == "min")
                {
                    string parameter = parts[1];

                    int index = GetMin(numbers, parameter);

                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (command == "first")
                {
                    int count = int.Parse(parts[1]);
                    string parameter = parts[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] firstElements = GetFirstElements(numbers, count, parameter);

                    PrintArray(firstElements);

                }
                else if (command == "last")
                {
                    int count = int.Parse(parts[1]);
                    string parameter = parts[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] lastElements = GetLastElements(numbers, count, parameter);

                    PrintArray(lastElements);
                }

            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void PrintArray(int[] elements)
        {
            Console.Write("[");

            bool printed = false;

            foreach (int element in elements)
            {
                if (element != -1)
                {
                    if (printed)
                    {
                        Console.Write($", {element} ");
                    }
                    else
                    {
                        Console.Write($"{element}");
                        printed = true;
                    }

                }
            }

            Console.WriteLine("]");

        }

        private static int[] GetLastElements(int[] numbers, int count, string parameter)
        {
            int[] result = new int[count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }

            int parity = GetParity(parameter);
            int index = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)           
            {
                int number = numbers[i];

                if (number % 2 == parity)
                {
                    result[index] = number;
                    index += 1;

                    if (index >= result.Length)
                    {
                        break;
                    }
                }
            }

            return result.Reverse().ToArray();
        }

        private static int[] GetFirstElements(int[] numbers, int count, string parameter)
        {
            int[] result = new int[count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }

            int parity = GetParity(parameter);
            int index = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == parity)
                {
                    result[index] = number;
                    index += 1;

                    if (index >= result.Length)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        private static int GetParity(string parameter)
        {
            if (parameter == "even")
            {
                return 0;
            }

            return 1;
        }
        private static int GetMin(int[] numbers, string parameter)
        {
            int parity = GetParity(parameter);

            int minNumber = int.MaxValue;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];

                if (currNumber <= minNumber &&
                    currNumber % 2 == parity)
                {
                    minNumber = currNumber;
                    index = i;
                }
            }

            return index;
        }
        private static int GetMax(int[] numbers, string parameter)
        {
            int parity = GetParity(parameter);

            int maxNumber = int.MinValue;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];

                if (currNumber >= maxNumber &&
                    currNumber % 2 == parity)
                {
                    maxNumber = currNumber;
                    index = i;
                }
            }

            return index;
        }
        private static void Exchange(int[] numbers, int index)
        {
            if (index < 0 && index >= numbers.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            for (int rotation = 0; rotation <= index; rotation++)
            {
                int firstNumber = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i - 1] = numbers[i];
                }
                numbers[numbers.Length - 1] = firstNumber;
            }
        }
    }
}
