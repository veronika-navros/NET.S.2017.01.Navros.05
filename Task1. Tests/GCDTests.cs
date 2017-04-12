using System;
using System.Diagnostics;
using NUnit.Framework;

namespace Task1.Tests
{
    public class GCDTests
    {
        [TestCase(1, 10, ExpectedResult = 1)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(24, 24, ExpectedResult = 24)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(3, 5, ExpectedResult = 1)]
        [TestCase(0, 10, ExpectedResult = 10)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(0, -3, ExpectedResult = 3)]
        [TestCase(-10, 0, ExpectedResult = 10)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(5, -10, ExpectedResult = 5)]
        [TestCase(-8, -10, ExpectedResult = 2)]
        public int FindByEuklidAlgorithm_2numbersGCD(int number1, int number2) => GCD.FindByEuklidAlgorithm(number1, number2);

        [TestCase(0, 1, 10, ExpectedResult = 1)]
        [TestCase(5, 0, 10, ExpectedResult = 5)]
        [TestCase(24, 24, 0, ExpectedResult = 24)]
        [TestCase(0, 1, 0, ExpectedResult = 1)]
        [TestCase(5, 0, 0, ExpectedResult = 5)]
        [TestCase(0, 0, 24, ExpectedResult = 24)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(3, 5, -3, ExpectedResult = 1)]
        [TestCase(0, 10, -5, ExpectedResult = 5)]
        [TestCase(-3, 1, 0, ExpectedResult = 1)]
        [TestCase(0, 3, -3, ExpectedResult = 3)]
        [TestCase(-10, 0, -8, ExpectedResult = 2)]
        [TestCase(-5, 10, 5, ExpectedResult = 5)]
        [TestCase(5, -10, -5, ExpectedResult = 5)]
        [TestCase(-8, -10, -16, ExpectedResult = 2)]
        public int FindByEuklidAlgorithm_3numbersGCD(int number1, int number2, int number3) => GCD.FindByEuklidAlgorithm(number1, number2, number3);

        [TestCase(0, 1, 10, 8, ExpectedResult = 1)]
        [TestCase(5, 0, 10, 8, 7, ExpectedResult = 1)]
        [TestCase(0, 24, 24, 0, ExpectedResult = 24)]
        [TestCase(0, 1, -1, 6, 0, ExpectedResult = 1)]
        [TestCase(5, 0, 0, 10, -5, ExpectedResult = 5)]
        [TestCase(0, 0, 24, 8, ExpectedResult = 8)]
        [TestCase(0, 0, 0, -5, 5, ExpectedResult = 5)]
        [TestCase( 5,ExpectedResult = 5)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-8, ExpectedResult = 8)]
        [TestCase(-6, 0, 3, -3, ExpectedResult = 3)]
        [TestCase(-10, -10, -10, 0, -10, 10, 10, 8, ExpectedResult = 2)]
        [TestCase(-5, 10, 5, 0, 3, ExpectedResult = 1)]
        [TestCase(5, 10, 205, 25, ExpectedResult = 5)]
        [TestCase(-8, -10, -16, -4, ExpectedResult = 2)]
        public int FindByEuklidAlgorithm_ArrayNumbersGCD(params int[] numbers) => GCD.FindByEuklidAlgorithm(numbers);

        [TestCase()]
        [TestCase(new int[] {})]
        public void FindByEuklidAlgorithm_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => GCD.FindByEuklidAlgorithm(numbers));
        }

        [TestCase(1, 10, ExpectedResult = 1)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(24, 24, ExpectedResult = 24)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(3, 5, ExpectedResult = 1)]
        [TestCase(0, 10, ExpectedResult = 10)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(0, -3, ExpectedResult = 3)]
        [TestCase(-10, 0, ExpectedResult = 10)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(5, -10, ExpectedResult = 5)]
        [TestCase(-8, -10, ExpectedResult = 2)]
        public int FindByBinaryAlgorithm_2numbersGCD( int number1, int number2) => GCD.FindByEuklidAlgorithm(number1, number2);

        [TestCase(0, 1, 10, ExpectedResult = 1)]
        [TestCase(5, 0, 10, ExpectedResult = 5)]
        [TestCase(24, 24, 0, ExpectedResult = 24)]
        [TestCase(0, 1, 0, ExpectedResult = 1)]
        [TestCase(5, 0, 0, ExpectedResult = 5)]
        [TestCase(0, 0, 24, ExpectedResult = 24)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(3, 5, -3, ExpectedResult = 1)]
        [TestCase(0, 10, -5, ExpectedResult = 5)]
        [TestCase(-3, 1, 0, ExpectedResult = 1)]
        [TestCase(0, 3, -3, ExpectedResult = 3)]
        [TestCase(-10, 0, -8, ExpectedResult = 2)]
        [TestCase(-5, 10, 5, ExpectedResult = 5)]
        [TestCase(5, -10, -5, ExpectedResult = 5)]
        [TestCase(-8, -10, -16, ExpectedResult = 2)]
        public int FindByBinaryAlgorithm_3numbersGCD(int number1, int number2, int number3) => GCD.FindByEuklidAlgorithm(number1, number2, number3);

        [TestCase(0, 1, 10, 8, ExpectedResult = 1)]
        [TestCase(5, 0, 10, 8, 7, ExpectedResult = 1)]
        [TestCase(0, 24, 24, 0, ExpectedResult = 24)]
        [TestCase(0, 1, -1, 6, 0, ExpectedResult = 1)]
        [TestCase(5, 0, 0, 10, -5, ExpectedResult = 5)]
        [TestCase(0, 0, 24, 8, ExpectedResult = 8)]
        [TestCase(0, 0, 0, -5, 5, ExpectedResult = 5)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(-8, ExpectedResult = 8)]
        [TestCase(-6, 0, 3, -3, ExpectedResult = 3)]
        [TestCase(-10, -10, -10, 0, -10, 10, 10, 8, ExpectedResult = 2)]
        [TestCase(-5, 10, 5, 0, 3, ExpectedResult = 1)]
        [TestCase(5, 10, 205, 25, ExpectedResult = 5)]
        [TestCase(-8, -10, -16, -4, ExpectedResult = 2)]
        public int FindByBinaryAlgorithm_ArrayNumbersGCD(params int[] numbers) => GCD.FindByEuklidAlgorithm(numbers);

        [TestCase()]
        [TestCase(new int[] { })]
        public void FindByBinaryAlgorithm_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => GCD.FindByBinaryAlgorithm( numbers));
        }
    }
}
