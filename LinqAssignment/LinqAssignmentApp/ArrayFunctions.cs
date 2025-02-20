using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAssignmentApp
{
 
    public static class ArrayFunctions
    {
        /// <summary>
        /// Returns all even numbers from the array.
        /// </summary>
        /// <param name="array">An array of integers.</param>
        /// <param name="skip">Optional number of even numbers to skip.</param>
        /// <returns>IEnumerable of even integers.</returns>
        public static IEnumerable<int> GetEvenNumbers(int[] array, int skip = 0)
        {
            return array.Where(n => n % 2 == 0).Skip(skip);
        }

        public static IEnumerable<int> GetOddNumbersAfterShuffle(int[] array, int skip = 0)
        {
            Random rnd = new Random();
            var shuffled = array.OrderBy(x => rnd.Next());
            return shuffled.Where(n => n % 2 != 0).Skip(skip);
        }

        
        public static (double Average, int Minimum, int Maximum) GetArrayStats(int[] array)
        {
            return (array.Average(), array.Min(), array.Max());
        }
    }
}
