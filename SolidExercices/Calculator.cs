using System;
using System.Linq;
using System.Data;//import this namespace

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            
            string[] numbers = operation.Split('+');
            decimal result = 0;
            foreach (var number in numbers)
            {
                result += Convert.ToDecimal(number);
            }
            
            return result;
            /*throw new NotImplementedException();*/
        }
    }
}