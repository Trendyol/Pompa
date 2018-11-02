using System;

namespace Pompa.ConsoleRunner
{
    class VerboseException : Exception
    {
        public VerboseException(string message) : base(message)
        {
        }

        public VerboseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}