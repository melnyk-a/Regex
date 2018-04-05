using System.Linq;

namespace Regex
{
    internal class AnyOneCharPattern : Pattern
    {
        public override IExpression GetPattern(string pattern)
        {
            if (pattern.Contains('.'))
            {
                _patternExpression = new AnyOfChar(SplitToTerminal(pattern));
            }
            else
            {
                _patternExpression = _next.GetPattern(pattern);
            }
            return _patternExpression;
        }
    }
}