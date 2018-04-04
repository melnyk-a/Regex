using System;

namespace Regex
{
    internal class InputIncorrectPatternException : Exception
    {
        public InputIncorrectPatternException(string message) : base(message)
        {
        }
    }
}
