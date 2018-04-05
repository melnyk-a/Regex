using System.Collections.Generic;

namespace Regex
{
    internal abstract class NonTerminalExp : IExpression
    {
        protected List<IExpression> _expressionsSet;
        public NonTerminalExp(List<IExpression> expressionsSet)
        {
            _expressionsSet = expressionsSet;
        }
        public abstract bool IsMatch(Context context);
        protected bool CanAdvance(Context context)
        {
            return !context.IsLastPosition();
        }
    }
}
