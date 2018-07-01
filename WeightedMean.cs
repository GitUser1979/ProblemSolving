/*
 * Calculating the Weighted Mean of numbers. 
 * Input: Given an array of integers and another array representing the 
 * respective weights of first array elements.
 * Output: Weighted mean of first array elements. 
 */

using System;
using System.Collections.Generic;
using System.IO;
class Solution
    {

    static decimal CalculateWeightedMean (int n, int[] numArray, int[] weightArray)
        {
        decimal sum = 0.0m;
        decimal sumOfWeights = 0.0m;
        for ( int i = 0; i < n; ++i )
            {
            sum = sum + numArray[i] * weightArray[i];
            sumOfWeights = sumOfWeights + weightArray[i];
            }

        decimal weightedMean = sum / sumOfWeights;
        return Math.Round(weightedMean, 1);
        }

    //Uncomment the following code to test it.

    //static void Main (String[] args)
    //    {
    //    int n = Convert.ToInt32(Console.ReadLine());

    //    string inputNumbers = Console.ReadLine();
    //    string[] arryOfStrings = inputNumbers.Split(null);
    //    int[] numArray = new int[n];
    //    int i = 0;
    //    foreach ( var item in arryOfStrings )
    //        {
    //        numArray[i] = Convert.ToInt32(item);
    //        ++i;
    //        }

    //    inputNumbers = Console.ReadLine();
    //    arryOfStrings = inputNumbers.Split(null);
    //    int[] weightsArray = new int[n];
    //    i = 0;
    //    foreach ( var item in arryOfStrings )
    //        {
    //        weightsArray[i] = Convert.ToInt32(item);
    //        ++i;
    //        }

    //    decimal weightedMean = Solution.CalculateWeightedMean(n, numArray, weightsArray);
    //    Console.WriteLine(weightedMean.ToString("0.0"));
    //    }
    }