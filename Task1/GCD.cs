using System;
using System.Diagnostics;
using System.Linq;

namespace Task1
{
    /// <summary>
    /// Calcaulates greatest common devisor for given numbers
    /// </summary>
    public static class GCD
    {
        #region Public members

        /// <summary>
        /// Calculates greates common devisor for 2 numbers using Euklid algorithm and determins the time elapsed for calculations in milliseconds
        /// </summary>
        /// <param name="elapsedTime">Time elapsed for calculations</param>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>Greatest common devisor of 2 source numbers</returns>
        public static int FindByEuklidAlgorithm(out double elapsedTime, int number1, int number2)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = EuklidAlgorithm(number1, number2);

            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Calculates greates common devisor for 3 numbers using Euklid algorithm and determins the time elapsed for calculations in milliseconds
        /// </summary>
        /// <param name="elapsedTime">Time elapsed for calculations</param>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <param name="number3">Yhird number</param>
        /// <returns>Greatest common devisor of 3 source numbers</returns>
        public static int FindByEuklidAlgorithm(out double elapsedTime, int number1, int number2, int number3)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = EuklidAlgorithm(number1, number2);
            result = EuklidAlgorithm(result, number3);

            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Calculates greates common devisor for more than 3 numbers using Euklid algorithm and determins the time elapsed for calculations in milliseconds
        /// </summary>
        /// <param name="elapsedTime">Time elapsed for calculations</param>
        /// <param name="numbers">Array of source numbers</param>
        /// <returns>Greatest common devisor of several source numbers</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static int FindByEuklidAlgorithm(out double elapsedTime, params int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentException();

            if (!numbers.Any())
                throw new ArgumentException();

            elapsedTime = 0;
            int result = numbers[0];
            if (numbers.Length == 1)
                return Math.Abs(result);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < numbers.Length; i++)
            {
                result = FindByEuklidAlgorithm(out elapsedTime, result, numbers[i]);
            }

            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Calculates greates common devisor for 2 numbers using Binary algorithm and determins the time elapsed for calculations in milliseconds
        /// </summary>
        /// <param name="elapsedTime">Time elapsed for calculations</param>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>Greatest common devisor of 2 source numbers</returns>
        public static int FindByBinaryAlgorithm(out double elapsedTime, int number1, int number2)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = BinaryAlgorithm(Math.Abs(number1), Math.Abs(number2));

            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Calculates greates common devisor for 3 numbers using Binary algorithm and determins the time elapsed for calculations in milliseconds
        /// </summary>
        /// <param name="elapsedTime">Time elapsed for calculations</param>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <param name="number3">Yhird number</param>
        /// <returns>Greatest common devisor of 3 source numbers</returns>
        public static int FindByBinaryAlgorithm(out double elapsedTime, int number1, int number2, int number3)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = BinaryAlgorithm(Math.Abs(number1), Math.Abs(number2));
            result = BinaryAlgorithm(Math.Abs(result), Math.Abs(number3));

            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Calculates greates common devisor for more than 3 numbers using Binary algorithm and determins the time elapsed for calculations in milliseconds
        /// </summary>
        /// <param name="elapsedTime">Time elapsed for calculations</param>
        /// <param name="numbers">Array of source numbers</param>
        /// <returns>Greatest common devisor of several source numbers</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// /// <exception cref="ArgumentException"></exception>
        public static int FindByBinaryAlgorithm(out double elapsedTime, params int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentException();

            if (!numbers.Any())
                throw new ArgumentException();

            elapsedTime = 0;
            int result = numbers[0];
            if (numbers.Length.Equals(1))
                return Math.Abs(result);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < numbers.Length; i++)
            {
                result = BinaryAlgorithm(Math.Abs(result), Math.Abs(numbers[i]));
            }

            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            return result;
        }

        #endregion

        #region Private members

        /// <summary>
        /// Implements Euklid algorithm for GCD search for 2 numbers
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>GCD of two source numbers</returns>
        static int EuklidAlgorithm(int number1, int number2)
        {
            number1 = Math.Abs(number1);
            number2 = Math.Abs(number2);

            if (number1 == 0)
                return number2;
            if (number2 == 0)
                return number1;

            while (number1 != number2)
            {
                if (number1 > number2)
                    number1 -= number2;
                else
                    number2 -= number1;
            }

            return number1;
        }

        /// <summary>
        /// Implements binary algorithm for GCD search for 2 numbers
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>GCD of two source numbers</returns>
        static int BinaryAlgorithm(int number1, int number2)
        {
            if (number1 == number2)
                return number1;
            if (number1 == 0)
                return number2;
            if (number2 == 0)
                return number1;

            if ((~number1 & 1) != 0)
            {
                if ((number2 & 1) != 0)
                    return BinaryAlgorithm(number1 >> 1, number2);
                return BinaryAlgorithm(number1 >> 1, number2 >> 1) << 1;
            }

            if ((~number2 & 1) != 0)
                return BinaryAlgorithm(number1, number2 >> 1);
            if (number1 > number2)
                return BinaryAlgorithm((number1 - number2) >> 1, number2);


            return BinaryAlgorithm((number2 - number1) >> 1, number1);
        }

        #endregion
    }
}