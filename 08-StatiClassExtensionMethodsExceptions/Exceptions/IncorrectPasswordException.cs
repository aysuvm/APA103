using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    internal class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException(int attemptsLeft)
       : base($"Incorrect password! Attempts left: {attemptsLeft}")
    }
}
