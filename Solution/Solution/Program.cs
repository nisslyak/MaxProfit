using NSubstitute.Core;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Formats.Asn1.AsnWriter;

public class Solution
{
    public static int MaxProfit(int[] prices)
    {

        int max = 0;
        int min = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }

            else if ((prices[i] - min) > max)
            {
                max = prices[i] - min;
            }
        }
        return max;
    }

    public static void Main(string[] args)
    {
        int[] prices = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

        int difference = MaxProfit(prices);
    }
}
