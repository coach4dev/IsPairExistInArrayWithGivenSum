using System;
using System.Collections.Generic;

namespace PairWithGivenSumExist
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 5, 6, 3, 8, 2 };
            int sum = 9;

            //use either of the 2 methods below i.e. with hash or with no hash
            var isPairExist = IsPairExistWithSumWithHash(arr, sum);

            Console.WriteLine(isPairExist);
            Console.ReadLine();
        }

        //naive solution with O(n^2)
        private static bool IsPairExistWithSum(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                        return true;
                }
            }
            return false;
        }

        //O(n) solution with HashSet
        private static bool IsPairExistWithSumWithHash(int[] arr, int sum)
        {
            if (arr == null || arr.Length < 2)
                return false;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (set.Contains(sum - arr[i]))
                {
                    return true;
                }
                set.Add(arr[i]);
            }
            return false;
        }
    }
}
