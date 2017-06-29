using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Globalization;

//import this namespace

namespace SolidExercices
{
    public class Calculator
    {
        /*public decimal Calculate(string operation)
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
            else if (operation.Contains("-"))
            {
                string[] numbers = operation.Split('-');
                result = Convert.ToDecimal(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result -= Convert.ToDecimal(numbers[i]);
                }
            }
            else if (operation.Contains("*"))
            {
                string[] numbers = operation.Split('*');
                result = Convert.ToDecimal(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result *= Convert.ToDecimal(numbers[i]);
                }
            }
            else if (operation.Contains("/"))
            {
                string[] numbers = operation.Split('/');
                result = Convert.ToDecimal(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result /= Convert.ToDecimal(numbers[i]);
                }
            }

            else
            {
                throw new NotImplementedException();

            }

            return result;

            /*throw new NotImplementedException();#1#
        }*/

        private readonly List<InterfaceOperations> _operations;

        public Calculator(List<InterfaceOperations> operations)
        {
            _operations = operations;
        }

        public decimal Calculate(string operations)
        {
            foreach (var operation in _operations)
            {
                if (operation.CanCalcul(operations))
                {
                    return operation.Calculate(operations);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}