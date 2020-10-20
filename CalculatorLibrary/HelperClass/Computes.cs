using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.HelperClass
{
    public static class Computes
    {

        //Overload typeConverter method
        public static double TypeConverter(string num1)
        {
            //This method take in a string argument and convert it to double and return double
            return Convert.ToDouble(num1);

        }

        public static double[] TypeConverter(string num1, string num2)
        {
            //This method take in two string argument and convert it to double and return array double
            double[] typeValues = new[] { Convert.ToDouble(num1), Convert.ToDouble(num2) };

            return typeValues;

        }

    }
}
