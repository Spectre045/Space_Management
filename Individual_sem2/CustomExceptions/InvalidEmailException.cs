﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message):base(message) { }
    }
}
