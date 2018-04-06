using System.Linq;
using System.Collections.Generic;

namespace Regex
{
    internal class NoneOfCharsPattern : Pattern
    {
        public override IExpression GetPattern(string pattern)
        {
            if (pattern.Contains("[^") && pattern.Contains(']'))
            {
                _patternExpression = new NoneOfChars(SplitToTerminal(pattern));
            }
            else
            {
                _patternExpression = _next.GetPattern(pattern);
            }
            return _patternExpression;
        }
        protected override List<IExpression> SplitToTerminal(string context)
        {
            List<IExpression> expressions = new List<IExpression>();

            int startIndex = context.IndexOf("[^");
            int endIndex = context.IndexOf(']');
            string charArray = context.Substring(startIndex + 2,
                                                endIndex - startIndex - 2);
            expressions.Add(new AnyOfChar(base.SplitToTerminal(charArray)));

            return expressions;
        }
    }
}