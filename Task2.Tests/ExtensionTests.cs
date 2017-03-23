using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.Tests
{
    public class ExtensionTests
    {
        [TestCase(2.28, ExpectedResult = "10.01001000")]
        [TestCase(3.5, ExpectedResult = "11.10000000")]
        [TestCase(12.524, ExpectedResult = "1100.10000110")]
        [TestCase(13, ExpectedResult = "1101")]
        public string ConvertToBinary_StringBinaryNumber(double number)
        {
            return number.ConvertToBinary();
        }
    }
}
