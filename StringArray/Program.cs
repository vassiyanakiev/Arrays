using System;
using System.Collections.Generic;
using System.Linq;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numbersSplit = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();            

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                int[] numbersArray = new int[numbersSplit.Length];

                for (int i = 0; i < numbersSplit.Length; i++)
                {

                    numbersArray[i] = int.Parse(numbersSplit[i]);

                }

                string[] commandSplit = command.Split(' ');

                int start = 0;
                int end = 0;
                string output;
                switch (commandSplit[0])
                {
                    case "reverse":
                        start = int.Parse(commandSplit[2]);
                        end = int.Parse(commandSplit[4]);
                        for (int i = 0 - 1; i < numbersArray.Length - 1; i++)
                        {
                            output = numbersArray.ToString() + ", ";
                            
                        }
                        break;
                    case "sort":

                        break;
                    case "remove":
                        start = int.Parse(commandSplit[1]);
                        for (int i = start - 1; i < numbersArray.Length - 1; i++)
                        {
                            output = numbersArray.ToString() + ",  ";
                            output += numbersArray[numbersArray.Length - 1];
                            Console.WriteLine(output);
                        }
                        break;
                }

            
            }

        }
    }
}
