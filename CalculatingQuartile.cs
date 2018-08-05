/*
 * Quartile
 * The quartiles of an ordered data set are the  points that split the data set into  equal groups. 
 * The  quartiles are defined as follows:
 * Q1: The first quartile is the middle number between the smallest number in a data set and its median.
 * Q2: The second quartile is the median ( percentile) of the data set.
 * Q3: The third quartile is the middle number between a data set's median and its largest number.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartile
    {
    class QuartileCalculator
        {
        /*
         * Calculates the Median for any array of integers.
         * 
         * Input: 
         *       n - Number of elements in the array
         *       numbers - Array of integers
         *       
         * Output:
         *       Returns the Median       
         */
        static int CalculateMedian (int n, int[] numbers)
            {
            Array.Sort(numbers);
            int mid1, mid2, mid = 0;

            if ( n % 2 == 0 )
                {
                mid1 = n / 2;
                mid2 = mid1 + 1;
                return (numbers[mid1-1] + numbers[mid2-1]) / 2;
                }
            else
                {
                mid = n / 2;
                return numbers[mid];
                }
            }

        int[] CreateSubArray (int n, int size, )
            {
            int index = 0;
            
            int[] q3Numbers = new int[size];
            for ( int i = (n / 2); i < n; ++i )
                {
                q3Numbers[index] = numbers[i];
                ++index;
                }
            return q3Numbers;

            }

            static void Main (String[] args)
            {
            //Read input: Read the number of elements in the array
            string num = Console.ReadLine();
            int n = 0;
            
            if ( !Int32.TryParse(num, out n) )
                {
                return;
                }

            //Read input: Read the array
            string numArray = Console.ReadLine();
            //string numArray = "3 7 8 5 12 14 21 15 18 14";
            string[] numStrings = numArray.Split(null);
            int[] numbers = new int[n];

            for ( int i = 0; i < n; ++i )
                {
                Int32.TryParse(numStrings[i], out numbers[i]);
                }

            int Q2 = QuartileCalculator.CalculateMedian(n, numbers);
            int Q1, Q3;

            int[] q1Numbers = new int[n/2];
            
            if ( n % 2 == 0 )
                {
                for ( int i = 0; i < n / 2; ++i )
                    {
                    q1Numbers[i] = numbers[i];
                    }

                Q1 = QuartileCalculator.CalculateMedian(n / 2, q1Numbers);
                }
            else
                {
                for ( int i = 0; i < n / 2; ++i )
                    {
                    q1Numbers[i] = numbers[i];
                    }

                Q1 = QuartileCalculator.CalculateMedian(n / 2, q1Numbers);
                }

            
            int index = 0;
            if ( n % 2 == 0 )
                {
                int size = n - n / 2;
                int[] q3Numbers = new int[size];
                for ( int i = (n / 2); i < n; ++i )
                    {
                    q3Numbers[index] = numbers[i];
                    ++index;
                    }

                Q3 = QuartileCalculator.CalculateMedian((n / 2), q3Numbers);
                }
            else
                {
                int size = n / 2;
                int[] q3Numbers = new int[size];
                for ( int i = (n / 2) + 1; i < n; ++i )
                    {
                    q3Numbers[index] = numbers[i];
                    ++index;
                    }

                Q3 = QuartileCalculator.CalculateMedian((n / 2), q3Numbers);
                }

            Console.WriteLine(Q1);
            Console.WriteLine(Q2);
            Console.WriteLine(Q3);
            }
        }
    }
