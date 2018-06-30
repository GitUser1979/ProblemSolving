/*
 * Calculate the mean, median, and mode.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMeadianMode
    {
    class Solution
        {
        public static double CalculateMean (int[] numArray, int n)
            {
            double sum = 0;
            for ( int i = 0; i < n; ++i )
                {
                sum = sum + numArray[i];
                }

            double mean = sum / n;
            return Math.Round(mean, 1);
            }

        public static double CalculateMedian (int[] numArray, int n)
            {
            double median = 0;
            Array.Sort(numArray);
            int mid = 0, mid1 = 0, mid2 = 0;
            if ( (n % 2) == 0 )
                {
                mid1 = n / 2;
                mid2 = mid1 + 1;
                median = Math.Round(((Convert.ToDouble(numArray[mid1-1]) + Convert.ToDouble(numArray[mid2-1])) / 2), 1);
                }
            else
                {
                mid = n / 2;
                median = numArray[mid];
                }

            return Math.Round(median, 1);
            }

        public static int CalculateMode (int[] numArray, int n)
            {
            int maxCount = 0;
            List<int> list = new List<int>();
            Array.Sort(numArray);
            ICollection<KeyValuePair<int, int>> openWith =
                new Dictionary<int, int>();

            for ( int i = 0; i < n; )
                {
                if ( list.Contains(numArray[i]) )
                    {
                    ++i;
                    continue;
                    }

                int count = 1;

                for ( int j = i; j < n-1; ++j )
                    {
                    if ( numArray[j] != numArray[j + 1] )
                        {
                        break;
                        }

                    ++count;
                    }

                openWith.Add(new KeyValuePair<int, int>(numArray[i], count));

                if ( count == maxCount )
                    {
                    list.Add(numArray[i]);
                    }

                if ( count > maxCount )
                    {
                    list.Clear();
                    maxCount = count;
                    list.Add(numArray[i]);
                    }

                if ( i >= count )
                    {
                    ++i;
                    }
                else
                    {
                    i = count;
                    }                
                }

            list.Sort();
            int mode = list[0];
            return mode;
            }

        //Client code for testing. 
        //Uncomment the following main method to test and run.

        //static void Main (String[] args)
        //    {
        //    //input the sample size
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    //input the sample as integer array (space separated integers)
        //    string inputNumbers = Console.ReadLine();
        //    string[] arryOfStrings = inputNumbers.Split(null);
        //    int[] numArray = new int[n];
        //    int i = 0;

        //    foreach ( var item in arryOfStrings )
        //        {
        //        numArray[i] = Convert.ToInt32(item);
        //        ++i;
        //        }

        //    double mean = Solution.CalculateMean(numArray, n);
        //    Console.WriteLine(mean);

        //    double median = Solution.CalculateMedian(numArray, n);
        //    Console.WriteLine(median);

        //    int mode = Solution.CalculateMode(numArray, n);
        //    Console.WriteLine(mode);
        //    }
        }
    }


