using System.Linq;

namespace Regex
{
    internal class ZeroOrOnePattern : Pattern
    {
        private IExpression _patternExpression = null;
        public override IExpression GetPattern(string pattern)
        {
            if (pattern.Contains('?'))
            {
                _patternExpression = new ZeroOrOneChar(SplitToTerminal(pattern));
            }
            else
            {
                _patternExpression = _next.GetPattern(pattern);
            }
            return _patternExpression;
        }
    }
}
