﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public interface InterfaceOperations
    {
        bool CanCalcul(string operation);
        decimal Calculate(string operation);
    }
}
