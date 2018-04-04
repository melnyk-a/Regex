using System.Collections.Generic;

namespace Regex
{
    internal abstract class Pattern
    {
        protected Pattern _next;
        public abstract IExpression GetPattern(string pattern);
        public void SetNext(Pattern next)
        {
            _next = next;
        }
        protected List<IExpression> SplitToTerminal(string context)
        {
            List<IExpression> expressions = new List<IExpression>();
            for (int i = 0; i < context.Length; ++i)
            {
                expressions.Add(new CharTerminalExpression(context[i]));
            }
            return expressions;
        }
    }
}
