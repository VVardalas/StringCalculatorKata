﻿using System;
using System.Collections.Generic;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private readonly string[] _operations = new[]
            {"1+2,3", "2 x 3,6", "6-1-3,8", "6,6/3", "6/0", "not an operation", "a+1", "12", ""};

        public void Run()
        {
            var operateurs = new List<InterfaceOperations>{new Sum(), new Soustraction(), new Division(), new Multiplication()};
            var calculator = new Calculator(operateurs);
            foreach (var operation in _operations)
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    Console.WriteLine(operation + " = " + result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }
    }
}
