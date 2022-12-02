namespace _08._Anonymous_Threat
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmndArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmndType = cmndArgs[0];

                if (cmndType == "merge")
                {
                    int startIndex = int.Parse(cmndArgs[1]);
                    int endIndex = int.Parse(cmndArgs[2]);

                    FixIndex(input, ref startIndex, ref endIndex);
                    MergeWords(input, startIndex, endIndex);
                }
                else if (cmndType == "divide")
                {
                    int index = int.Parse(cmndArgs[1]);
                    int partitions = int.Parse(cmndArgs[2]);

                    string word = input[index];
                    List<string> partitionsList = DivideWord(word, partitions);

                    input.RemoveAt(index);
                    input.InsertRange(index, partitionsList);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
        static void FixIndex(List<string> words, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex >= words.Count)
            {
                endIndex = words.Count - 1;
            }

            if (startIndex >= words.Count)
            {
                startIndex = words.Count - 1;
            }

            if (endIndex >= words.Count)
            {
                endIndex = words.Count - 1;
            }
        }

        static void MergeWords(List<string> input, int startIndex, int endIndex)
        {
            string mergedWords = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = input[startIndex];
                mergedWords += currWord;
                input.RemoveAt(startIndex);
            }
            input.Insert(startIndex, mergedWords);
        }

        static List<string> DivideWord(string word, int partitions)
        {
            int substringLength = word.Length / partitions;
            int lastSubstringLength = substringLength + word.Length % partitions;

            List<string> partitionsList = new List<string>();
            for (int i = 0; i < partitions; i++)
            {
                int desiredLength = substringLength;
                if (i == partitions - 1)
                {
                    desiredLength = lastSubstringLength;
                }

                char[] newPartitionArr = word
                    .Skip(i * substringLength)
                    .Take(desiredLength)
                    .ToArray();
                string newPartition = String.Join("", newPartitionArr);
                partitionsList.Add(newPartition);
            }

            return partitionsList;
        }
    }
}
