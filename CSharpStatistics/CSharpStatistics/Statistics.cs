/* File: Biolab_Statistics.cs
 * Author: Daniel Teodoro Gonçalves Mariano
 * Email: dtgmariano@gmail.com
 * Creation Date: 2015/03/05
 */
namespace Biolab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// CSharp static class to provide statistical methods
    /// </summary>
    public static class Statistics
    {
        /// <summary>
        /// Calculates Population Average
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double Average_Population(List<double> nums)
        {
            return nums.Average();
        }

        /// <summary>
        /// Calculates Population Average
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Average_Population(List<int> nums)
        {
            return Convert.ToInt32(nums.Average());
        }

        /// <summary>
        /// Calculates Population Standard Deviation
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double StandardDeviation_Population(List<double> nums)
        {
            double sum = 0.0;
            nums.ForEach(x => sum += Math.Pow((x - nums.Average()), 2));
            return Math.Sqrt(sum / (nums.Count));
        }

        /// <summary>
        /// Calculates Population Standard Deviation
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double StandardDeviation_Population(List<int> nums)
        {
            double sum = 0.0;
            nums.ForEach(x => sum += Math.Pow((x - nums.Average()), 2));
            return Math.Sqrt(sum / (nums.Count));
        }

        /// <summary>
        /// Calculates Sample Standard Deviation
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double StandardDeviation_Sample(List<double> nums)
        {
            
            double sum = 0.0;

            if(nums.Count>1)
            {
                nums.ForEach(x => sum += Math.Pow((x - nums.Average()), 2));
                return Math.Sqrt(sum / (nums.Count - 1));
            }
            else
            {
                return 0.0;
            }
            
        }

        /// <summary>
        /// Calculates Sample Standard Deviation
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double StandardDeviation_Sample(List<int> nums)
        {
            double sum = 0.0;
            nums.ForEach(x => sum += Math.Pow((x - nums.Average()), 2));
            return Math.Sqrt(sum / (nums.Count - 1));
        }

        /// <summary>
        /// Calculates Factorial for an integer i
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

    }

    public enum Hyphotesis
    {
        Ho_Is_True,
        Ho_Is_False,
        Ha_Is_True,
        Ha_Is_False
    }
}
