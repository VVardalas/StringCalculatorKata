using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class Soustraction : InterfaceOperations
    {
        public bool CanCalcul(string operation)
        {
            return operation.Contains('-');
        }
        public decimal Calculate(string operation)
        {
            decimal result = 0;
            if (operation.Contains("-"))
            {
                string[] numbers = operation.Split('-');
                result = Convert.ToDecimal(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result -= Convert.ToDecimal(numbers[i]);
                }
            }
            return result;
        }
    }
}
