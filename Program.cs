using System;
using System.Collections.Generic;

namespace c__Bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = new int[] { 1, 2, 5, 3, 5, 7 };
            List<int> result = new List<int>();
            int previousNum = inputArr[inputArr.Length - 1];
            result.Add(previousNum);

            for (int i = inputArr.Length - 2; i >= 1; i--)
            {
                if ((inputArr[i] > previousNum) || (inputArr[i] < inputArr[i - 1]))
                    continue;
                previousNum = inputArr[i];
                result.Add(previousNum);
            }

            if (inputArr[0] <= previousNum)
                result.Add(inputArr[0]);

            result.Reverse();

            Console.Write(string.Join(" ", result));

            Console.ReadLine();
        }
    }
}

