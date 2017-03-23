using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Implements extension methods
    /// </summary>
    public static class Extension
    {
        #region Public members

        /// <summary>
        /// Extension method that gets binary representation of double number
        /// </summary>
        /// <param name="number">Double number</param>
        /// <returns>Binary representation of double number</returns>
        public static string ConvertToBinary(this double number)
        {
            int integerPart = Convert.ToInt32(number.ToString(CultureInfo.CurrentCulture).Split(',')[0]);
            double fractionalPart = number - integerPart;

            string result = Convert.ToString(integerPart, 2) + GetBinaryFractionalPart(fractionalPart);

            return result;
        }

        #endregion

        #region Private members

        /// <summary>
        /// Gets binary representation of fractional part of double number
        /// </summary>
        /// <param name="fractionalPart">Fractional part of double number</param>
        /// <returns>Binary representation of fractional part</returns>
        static string GetBinaryFractionalPart(double fractionalPart)
        {
            if (fractionalPart.Equals(0))
                return string.Empty;

            string result = ".";

            while(fractionalPart > 0.01)
            {
                fractionalPart *= 2;
                if (fractionalPart > 1)
                {
                    result += "1";
                    fractionalPart--;
                }
                else
                    result += "0";

                if (result.Length == 20)
                    break;
            }

            return result;
        }

        #endregion
    }
}
