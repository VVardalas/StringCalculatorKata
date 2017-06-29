using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class Multiplication : InterfaceOperations
    {
        public bool CanCalcul(string operation)
        {
            return operation.Contains('x');
        }

        public decimal Calculate(string operation)
        {
            decimal result = 0;
            if (operation.Contains("x"))
            {
                string[] numbers = operation.Split('x');
                result = Convert.ToDecimal(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result *= Convert.ToDecimal(numbers[i]);
                }
            }
            return result;
        }
    }
}
