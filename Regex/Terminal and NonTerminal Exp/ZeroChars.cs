using System.Collections.Generic;

namespace Regex
{
    internal class ZeroChars : NonTerminalExp
    {
        public ZeroChars(List<IExpression> expressionsSet) : base(expressionsSet)
        {
        }

        public override bool IsMatch(Context context)
        {
            bool isMatch = true;
            for (int i = 0; i < _expressionsSet.Count; ++i)
            {
                if (_expressionsSet[i].IsMatch(context))
                {
                    if (CanAdvance(context))
                    {
                        context.Advance(1);
                    }
                    else
                    {
                        if (i != _expressionsSet.Count - 1)
                        {
                            isMatch = false;
                            break;
                        }
                    }
                }
                else
                {
                    isMatch = false;
                    break;
                }
            }
            return isMatch;
        }
    }
}