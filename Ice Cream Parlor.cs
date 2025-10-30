using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    /*
     * Complete the 'icecreamParlor' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER m
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        // Dictionary to store cost -> index (1-based)
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Count; i++)
        {
            int cost = arr[i];
            int complement = m - cost;

            if (map.ContainsKey(complement))
            {
                // Found the pair, return 1-based indices
                return new List<int> { map[complement], i + 1 };
            }

            if (!map.ContainsKey(cost))
                map[cost] = i + 1; // store index (1-based)
        }

        return new List<int>(); // just in case, though problem guarantees one solution
    }

    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int m = Convert.ToInt32(Console.ReadLine().Trim());

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList();

            List<int> result = icecreamParlor(m, arr);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
