using System.Collections.Generic;

namespace Regex
{
    internal class ZeroOrOneChar : NonTerminalExp
    {
        public ZeroOrOneChar(List<IExpression> expressionsSet) : base(expressionsSet)
        {
        }
        public override bool IsMatch(Context context)
        {
            bool isMatch = false;
            for (int i = 0; i < _expressionsSet.Count; ++i)
            {
                isMatch = _expressionsSet[i].IsMatch(context);
                if (isMatch)
                {
                    break;
                }
            }
            return isMatch;
        }
    }
}
