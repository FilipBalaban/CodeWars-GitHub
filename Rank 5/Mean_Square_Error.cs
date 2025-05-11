using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_GitHub.Rank_5
{
    internal class Mean_Square_Error
    {
        /* Instructions:
         * accepts two integer arrays of equal length
         * compares the value each member in one array to the corresponding member in the other
         * squares the absolute value difference between those two values
         * and returns the average of those squared absolute value difference between each member pair.
         */

        /* Examples
         * [1, 2, 3], [4, 5, 6]              -->   9   because (9 + 9 + 9) / 3
         * [10, 20, 10, 2], [10, 25, 5, -2]  -->  16.5 because (0 + 25 + 25 + 16) / 4
         * [-1, 0], [0, -1]                  -->   1   because (1 + 1) / 2
         */
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            // TODO
            if(firstArray.Length != secondArray.Length)
            {
                throw new ArgumentException("Invalid argument: arrays must have equal number of elements!");
            }
            double sum = 0;
            for (int i = 0; i < firstArray.Length; i++) 
            {
                sum += Math.Pow(Math.Abs(firstArray[i] - secondArray[i]), 2);
            }
            return sum / firstArray.Length;
        }

    }
}
