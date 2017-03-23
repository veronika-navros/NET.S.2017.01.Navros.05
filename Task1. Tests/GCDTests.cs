using System;
using System.Diagnostics;
using NUnit.Framework;

namespace Task1.Tests
{
    public class GCDTests
    {
        [TestCase(null, 1, 10, ExpectedResult = 1)]
        [TestCase(null, 5, 10, ExpectedResult = 5)]
        [TestCase(null, 24, 24, ExpectedResult = 24)]
        [TestCase(null, 0, 0, ExpectedResult = 0)]
        [TestCase(null, 3, 5, ExpectedResult = 1)]
        [TestCase(null, 0, 10, ExpectedResult = 10)]
        [TestCase(null, 1, 0, ExpectedResult = 1)]
        [TestCase(null, 0, -3, ExpectedResult = 3)]
        [TestCase(null, -10, 0, ExpectedResult = 10)]
        [TestCase(null, -5, 10, ExpectedResult = 5)]
        [TestCase(null, 5, -10, ExpectedResult = 5)]
        [TestCase(null, -8, -10, ExpectedResult = 2)]
        public int FindByEuklidAlgorithm_2numbersGCD(out double elapsedTime, int number1, int number2)
        {
            int gcd = GCD.FindByEuklidAlgorithm(out elapsedTime, number1, number2);
            Debug.WriteLine("Elapsed time: " + elapsedTime + " milliseconds");
            return gcd;
        }

        [TestCase(null, 0, 1, 10, ExpectedResult = 1)]
        [TestCase(null, 5, 0, 10, ExpectedResult = 5)]
        [TestCase(null, 24, 24, 0, ExpectedResult = 24)]
        [TestCase(null, 0, 1, 0, ExpectedResult = 1)]
        [TestCase(null, 5, 0, 0, ExpectedResult = 5)]
        [TestCase(null, 0, 0, 24, ExpectedResult = 24)]
        [TestCase(null, 0, 0, 0, ExpectedResult = 0)]
        [TestCase(null, 3, 5, -3, ExpectedResult = 1)]
        [TestCase(null, 0, 10, -5, ExpectedResult = 5)]
        [TestCase(null, -3, 1, 0, ExpectedResult = 1)]
        [TestCase(null, 0, 3, -3, ExpectedResult = 3)]
        [TestCase(null, -10, 0, -8, ExpectedResult = 2)]
        [TestCase(null, -5, 10, 5, ExpectedResult = 5)]
        [TestCase(null, 5, -10, -5, ExpectedResult = 5)]
        [TestCase(null, -8, -10, -16, ExpectedResult = 2)]
        public int FindByEuklidAlgorithm_3numbersGCD(out double elapsedTime, int number1, int number2, int number3)
        {
            int gcd =  GCD.FindByEuklidAlgorithm(out elapsedTime, number1, number2, number3);
            Debug.WriteLine("Elapsed time: " + elapsedTime + " milliseconds");
            return gcd;
        }

        [TestCase(null, 0, 1, 10, 8, ExpectedResult = 1)]
        [TestCase(null, 5, 0, 10, 8, 7, ExpectedResult = 1)]
        [TestCase(null, 0, 24, 24, 0, ExpectedResult = 24)]
        [TestCase(null, 0, 1, -1, 6, 0, ExpectedResult = 1)]
        [TestCase(null, 5, 0, 0, 10, -5, ExpectedResult = 5)]
        [TestCase(null, 0, 0, 24, 8, ExpectedResult = 8)]
        [TestCase(null, 0, 0, 0, -5, 5, ExpectedResult = 5)]
        [TestCase(null,  5,ExpectedResult = 5)]
        [TestCase(null, 0, ExpectedResult = 0)]
        [TestCase(null, -8, ExpectedResult = 8)]
        [TestCase(null, -6, 0, 3, -3, ExpectedResult = 3)]
        [TestCase(null, -10, -10, -10, 0, -10, 10, 10, 8, ExpectedResult = 2)]
        [TestCase(null, -5, 10, 5, 0, 3, ExpectedResult = 1)]
        [TestCase(null, 5, 10, 205, 25, ExpectedResult = 5)]
        [TestCase(null, -8, -10, -16, -4, ExpectedResult = 2)]
        public int FindByEuklidAlgorithm_ArrayNumbersGCD(out double elapsedTime, params int[] numbers)
        {
            int gcd = GCD.FindByEuklidAlgorithm(out elapsedTime, numbers);
            Debug.WriteLine("Elapsed time: " + elapsedTime + " milliseconds");
            return gcd;
        }

        [TestCase()]
        [TestCase(new int[] {})]
        public void FindByEuklidAlgorithm_ThrowsArgumentException(params int[] numbers)
        {
            double elapsedTime = 0;
            Assert.Throws<ArgumentException>(() => GCD.FindByEuklidAlgorithm(out elapsedTime, numbers));
        }

        [TestCase(null, 1, 10, ExpectedResult = 1)]
        [TestCase(null, 5, 10, ExpectedResult = 5)]
        [TestCase(null, 24, 24, ExpectedResult = 24)]
        [TestCase(null, 0, 0, ExpectedResult = 0)]
        [TestCase(null, 3, 5, ExpectedResult = 1)]
        [TestCase(null, 0, 10, ExpectedResult = 10)]
        [TestCase(null, 1, 0, ExpectedResult = 1)]
        [TestCase(null, 0, -3, ExpectedResult = 3)]
        [TestCase(null, -10, 0, ExpectedResult = 10)]
        [TestCase(null, -5, 10, ExpectedResult = 5)]
        [TestCase(null, 5, -10, ExpectedResult = 5)]
        [TestCase(null, -8, -10, ExpectedResult = 2)]
        public int FindByBinaryAlgorithm_2numbersGCD(out double elapsedTime, int number1, int number2)
        {
            int gcd = GCD.FindByEuklidAlgorithm(out elapsedTime, number1, number2);
            Debug.WriteLine("Elapsed time: " + elapsedTime + " milliseconds");
            return gcd;
        }

        [TestCase(null, 0, 1, 10, ExpectedResult = 1)]
        [TestCase(null, 5, 0, 10, ExpectedResult = 5)]
        [TestCase(null, 24, 24, 0, ExpectedResult = 24)]
        [TestCase(null, 0, 1, 0, ExpectedResult = 1)]
        [TestCase(null, 5, 0, 0, ExpectedResult = 5)]
        [TestCase(null, 0, 0, 24, ExpectedResult = 24)]
        [TestCase(null, 0, 0, 0, ExpectedResult = 0)]
        [TestCase(null, 3, 5, -3, ExpectedResult = 1)]
        [TestCase(null, 0, 10, -5, ExpectedResult = 5)]
        [TestCase(null, -3, 1, 0, ExpectedResult = 1)]
        [TestCase(null, 0, 3, -3, ExpectedResult = 3)]
        [TestCase(null, -10, 0, -8, ExpectedResult = 2)]
        [TestCase(null, -5, 10, 5, ExpectedResult = 5)]
        [TestCase(null, 5, -10, -5, ExpectedResult = 5)]
        [TestCase(null, -8, -10, -16, ExpectedResult = 2)]
        public int FindByBinaryAlgorithm_3numbersGCD(out double elapsedTime, int number1, int number2, int number3)
        {
            int gcd = GCD.FindByEuklidAlgorithm(out elapsedTime, number1, number2, number3);
            Debug.WriteLine("Elapsed time: " + elapsedTime + " milliseconds");
            return gcd;
        }

        [TestCase(null, 0, 1, 10, 8, ExpectedResult = 1)]
        [TestCase(null, 5, 0, 10, 8, 7, ExpectedResult = 1)]
        [TestCase(null, 0, 24, 24, 0, ExpectedResult = 24)]
        [TestCase(null, 0, 1, -1, 6, 0, ExpectedResult = 1)]
        [TestCase(null, 5, 0, 0, 10, -5, ExpectedResult = 5)]
        [TestCase(null, 0, 0, 24, 8, ExpectedResult = 8)]
        [TestCase(null, 0, 0, 0, -5, 5, ExpectedResult = 5)]
        [TestCase(null, 5, ExpectedResult = 5)]
        [TestCase(null, 0, ExpectedResult = 0)]
        [TestCase(null, -8, ExpectedResult = 8)]
        [TestCase(null, -6, 0, 3, -3, ExpectedResult = 3)]
        [TestCase(null, -10, -10, -10, 0, -10, 10, 10, 8, ExpectedResult = 2)]
        [TestCase(null, -5, 10, 5, 0, 3, ExpectedResult = 1)]
        [TestCase(null, 5, 10, 205, 25, ExpectedResult = 5)]
        [TestCase(null, -8, -10, -16, -4, ExpectedResult = 2)]
        public int FindByBinaryAlgorithm_ArrayNumbersGCD(out double elapsedTime, params int[] numbers)
        {
            int gcd = GCD.FindByEuklidAlgorithm(out elapsedTime, numbers);
            Debug.WriteLine("Elapsed time: " + elapsedTime + " milliseconds");
            return gcd;
        }

        [TestCase()]
        [TestCase(new int[] { })]
        public void FindByBinaryAlgorithm_ThrowsArgumentException(params int[] numbers)
        {
            double elapsedTime = 0;
            Assert.Throws<ArgumentException>(() => GCD.FindByBinaryAlgorithm(out elapsedTime, numbers));
        }
    }
}
