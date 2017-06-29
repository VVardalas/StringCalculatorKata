using System;
using System.Linq;
using System.Data;
using System.Globalization;

//import this namespace

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal result = 0;
            if (operation.Contains("+"))
            {
                string[] numbers = operation.Split('+');
                result = Convert.ToDecimal(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result += Convert.ToDecimal(numbers[i]);
                }
            }
            if (operation.Contains("-"))
            {
                string[] numbers = operation.Split('-');
                result = Convert.ToDecimal(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result -= Convert.ToDecimal(numbers[i]);
                }
            }
            if (operation.Contains("*"))
            {
                string[] numbers = operation.Split('*');
                result = Convert.ToDecimal(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result *= Convert.ToDecimal(numbers[i]);
                }
            }
            if (operation.Contains("/"))
            {
                string[] numbers = operation.Split('/');
                result = Convert.ToDecimal(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result /= Convert.ToDecimal(numbers[i]);
                }
            }


            return result;

            /*throw new NotImplementedException();*/
        }
    }
}