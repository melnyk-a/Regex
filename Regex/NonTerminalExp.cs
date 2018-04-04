using System.Collections.Generic;

namespace Regex
{
    internal abstract class NonTerminalExp : IExpression
    {
        protected List<IExpression> _charSet;
        public NonTerminalExp(List<IExpression> charSet)
        {
            _charSet = charSet;
        }
        public abstract bool IsMatch(Context context);
    }
}
