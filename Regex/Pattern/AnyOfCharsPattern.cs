﻿using System.Linq;

namespace Regex
{
    internal class AnyOfCharsPattern : Pattern
    {
        public override IExpression GetPattern(string pattern)
        {
            if (pattern.Contains('[') && pattern.Contains(']'))
            {
                int startIndex = pattern.IndexOf('[');
                int endIndex = pattern.IndexOf(']');
                string charArray = pattern.Substring(startIndex+1,
                                                    endIndex - startIndex-1);
                _patternExpression = new AnyOfChars(SplitToTerminal(charArray));
            }
            else
            {
                _patternExpression = _next.GetPattern(pattern);
            }
            return _patternExpression;
        }
    }
}