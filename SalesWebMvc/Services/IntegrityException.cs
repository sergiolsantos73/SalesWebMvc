﻿using System;

namespace SalesWebMvc.Services
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message) { }
    }
}
