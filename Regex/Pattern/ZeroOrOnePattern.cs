using System.Linq;
using System.Collections.Generic;

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
        protected override List<IExpression> SplitToTerminal(string context)
        {
            List<IExpression> expressions = new List<IExpression>();

            int indexOfQuestion = context.IndexOf('?');
            string zeroMatchContext = context.Remove(indexOfQuestion, 1);
            expressions.Add(new ZeroChar(base.SplitToTerminal(zeroMatchContext)));

            string oneMatchContext = context.Replace('?', '.');
            expressions.Add(new AnyOneChar(base.SplitToTerminal(zeroMatchContext)));

            return expressions;
        }
    }
}
